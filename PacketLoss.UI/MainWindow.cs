using ClosedXML.Excel;
using PacketLoss.Domain;
using PacketLoss.UI.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PacketLoss.UI
{

	public partial class MainWindow : Form
	{

		#region Fields

		private PingCriteria _settingsCriteria;

		private PingInstance _singlePingInstance;

		private PingReplyStats _pingReplyStats;

		private MainWindowPresenter _mainWindowPresenter;

		private List<PingReply> _lastFivePingReplies; 

		#endregion Fields

		#region Properties

		/*public int RealTimePing
		{
			set
			{
				this.txtRealTimePing.Text = value.ToString();
			}
		}*/

		/*public TextBox RealTimePing
		{
			get
			{
				return txtRealTimePing;
			}
			set
			{
				txtRealTimePing = value;
			}
		}*/
		
		#endregion Properties

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();

			_settingsCriteria = new PingCriteria();

			_pingReplyStats = new PingReplyStats();

			_lastFivePingReplies = new List<PingReply>(5);
			
			_mainWindowPresenter = new MainWindowPresenter
			{
				MainWindow = this
			};

			bsCriteria.DataSource = _settingsCriteria;

			bsPingReplyStats.DataSource = _pingReplyStats;

			#region Event Handler Declaration

			btnSettingsStart.Click += BtnSettingsStart_Click;
			btnSettingsReset.Click += BtnSettingsReset_Click;
			btnSettingsStop.Click += BtnSettingsStop_Click;
			btnSettingsTest.Click += BtnSettingsTest_Click;
			btnSaveResults.Click += BtnSaveResults_Click;

			startTestToolStripMenuItem.Click += BtnSettingsStart_Click;
			testToolStripMenuItem.Click += BtnSettingsTest_Click;
			stopTestToolStripMenuItem.Click += BtnSettingsStop_Click;
			saveResultsToolStripMenuItem.Click += BtnSaveResults_Click;
			resetSettingsToolStripMenuItem.Click += BtnSettingsReset_Click;
			exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;

			_mainWindowPresenter.BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

			_mainWindowPresenter.BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			
			#endregion Event Handler Declaration
		}

		#endregion Constructors

		#region Event Handlers

		void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pbPingProgress.Value = (e.ProgressPercentage > 100) ? 100 : e.ProgressPercentage;

			PingReply currentPingReply = (PingReply)e.UserState;

			UpdateRealTimePing(currentPingReply);
		}

		private void BtnSaveResults_Click(object sender, EventArgs e)
		{
			if (bsPingReplies.DataSource is IList<PingInstanceReply>)
			{
				SaveFileDialog sfdWorkbookSave = new SaveFileDialog
					{
						Title = "Save Results",
						ValidateNames = true,
						AddExtension = true,
						DefaultExt = "xlsx",
						AutoUpgradeEnabled = true,
						Filter = "Excel Files (*.xlsx)|*.xlsx"
					};

				sfdWorkbookSave.ShowDialog();

				if (sfdWorkbookSave.FileName != string.Empty)
				{
					SaveResults(sfdWorkbookSave.FileName);  
				}
			}
		}

		private void BtnSettingsStop_Click(object sender, EventArgs e)
		{
			if (_mainWindowPresenter.BackgroundWorker != null)
			{
				_mainWindowPresenter.BackgroundWorker.CancelAsync();
			}

			pbPingProgress.Value = 100;
		}

		private void BtnSettingsReset_Click(object sender, EventArgs e)
		{
			ResetCriteria();
		}

		private void BtnSettingsStart_Click(object sender, EventArgs e)
		{
			switch (this.btnSettingsStart.Text)
			{
				case "Start":
					_settingsCriteria = (PingCriteria)bsCriteria.DataSource;
					_singlePingInstance = MainWindowPresenter.ConvertPingInstance(_settingsCriteria);
					_mainWindowPresenter.PingWorker(_singlePingInstance, _settingsCriteria.NumberOfPings);
					btnSettingsStart.Text = "Pause";
					_mainWindowPresenter.PauseEvent.Set();
					break;
				case "Pause":
					btnSettingsStart.Text = "Continue";
					_mainWindowPresenter.PauseEvent.Reset();
					break;
				case "Continue":
					btnSettingsStart.Text = "Pause";
					_mainWindowPresenter.PauseEvent.Set();
					break;
			}

			//btnSettingsStart.Enabled = false;
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnSettingsStart.Text = "Start";
			btnSettingsStart.Enabled = true;

			IList<PingInstanceReply> pingReplies = _mainWindowPresenter.PingReplies;

			bsPingReplies.DataSource = pingReplies;

			txtAverageRoundTripTime.Text = Convert.ToString(pingReplies.Average(i => i.RoundTripTime));
			txtSuccessfulPings.Text = Convert.ToString(pingReplies.Count(i => i.Status == IPStatus.Success));
		}

		private void BtnSettingsTest_Click(object sender, EventArgs e)
		{
			_settingsCriteria = (PingCriteria)bsCriteria.DataSource;

			MainWindowPresenter.IsPingCriteriaValid(_settingsCriteria);
		}

		#endregion Event Handlers
		
		#region Methods

		private void ResetCriteria()
		{
			PingCriteria pingCriteria = new PingCriteria();

			bsCriteria.DataSource = pingCriteria;
		}

		private void UpdateRealTimePing(PingReply currentPingReply)
		{
			//Round Trip Time
			if (_lastFivePingReplies.Count >= 5)
			{
				_lastFivePingReplies.RemoveAt(0);
			}

			_lastFivePingReplies.Add(currentPingReply);

			string averagePingTime = _lastFivePingReplies.Select(i => i.RoundtripTime).Average().ToString();

			txtRealTimePingTime.Text = string.Format("{0:0.0}", double.Parse(averagePingTime)); 

			//Status
			if (currentPingReply.Status != IPStatus.Success)
			{
				txtRealTimePingStatus.ForeColor = Color.Red;
			}
			else
			{
				txtRealTimePingStatus.ForeColor = Color.Lime;
			}

			txtRealTimePingStatus.Text = currentPingReply.Status.ToString();
		}

		private void SaveResults(string fileName)
		{
			IList<PingInstanceReply> replyList = (IList<PingInstanceReply>)bsPingReplies.DataSource;

			PingInstanceReply singleReply = replyList.First();

			XLWorkbook workBook = new XLWorkbook();

			IXLWorksheet workSheet = workBook.Worksheets.Add("Results");

			workSheet.Cell(1, 1).Value = "Address";
			workSheet.Cell(1, 2).Value = singleReply.Address.ToString();

			workSheet.Cell(2, 1).Value = "Buffer Length";
			workSheet.Cell(2, 2).Value = singleReply.BufferLength.Value;

			workSheet.Cell(3, 1).Value = "Fragment";
			workSheet.Cell(3, 2).Value = singleReply.DontFragment.ToString();

			workSheet.Cell(4, 1).Value = "Time To Live";
			workSheet.Cell(4, 2).Value = singleReply.TimeToLive.Value;

			workSheet.Cell(5, 1).Value = "Number Of Pings";
			workSheet.Cell(5, 2).Value = replyList.Count;

			workSheet.Cell(7, 1).Value = "Ping Number";
			workSheet.Cell(7, 2).Value = "Status";
			workSheet.Cell(7, 3).Value = "Round Trip Time";

			for (int i = 8; i <= replyList.Count + 7; i++)
			{
				workSheet.Cell(i, 1).Value = i - 7;
				workSheet.Cell(i, 2).Value = replyList[i - 8].Status.ToString();
				workSheet.Cell(i, 3).Value = replyList[i - 8].RoundTripTime.ToString();
			}

			workBook.SaveAs(fileName);

			workBook.Dispose();
		}

		#endregion Methods
	}
}
