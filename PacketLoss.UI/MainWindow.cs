using System.Linq;
using System.Net.NetworkInformation;
using PacketLoss.Domain;
using PacketLoss.UI.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PacketLoss.UI
{
	using System.Drawing;

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
			_mainWindowPresenter.BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

			_mainWindowPresenter.BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			
			#endregion Event Handler Declaration
		}


		private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pbPingProgress.Value = (e.ProgressPercentage > 100) ? 100 : e.ProgressPercentage;

			PingReply currentPingReply = (PingReply)e.UserState;

			UpdateRealTimePing(currentPingReply);
		}

		#endregion Constructors

		#region Event Handlers

		private void BtnSettingsStop_Click(object sender, EventArgs e)
		{
			if (_mainWindowPresenter.BackgroundWorker != null)
			{
				_mainWindowPresenter.BackgroundWorker.CancelAsync();
			}
		}

		private void BtnSettingsReset_Click(object sender, EventArgs e)
		{
			ResetCriteria();
		}

		private void BtnSettingsStart_Click(object sender, EventArgs e)
		{
			_settingsCriteria = (PingCriteria)bsCriteria.DataSource;

			_singlePingInstance = MainWindowPresenter.ConvertPingInstance(_settingsCriteria);

			_mainWindowPresenter.PingWorker(_singlePingInstance, _settingsCriteria.NumberOfPings);

			btnSettingsStart.Text = "Busy";
			btnSettingsStart.Enabled = false;
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

		#endregion Methods

	}
}
