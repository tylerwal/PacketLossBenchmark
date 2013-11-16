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
	public partial class MainWindow : Form
	{

		#region Fields

		private PingCriteria _settingsCriteria;

		private PingInstance _singlePingInstance;

		private PingReplyStats _pingReplyStats;

		private MainWindowPresenter _mainWindowPresenter;

		#endregion Fields

		#region Properties

		#endregion Properties

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();

			_settingsCriteria = new PingCriteria();

			_pingReplyStats = new PingReplyStats();
			
			_mainWindowPresenter = new MainWindowPresenter();

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

		

		void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pbPingProgress.Value = (e.ProgressPercentage > 100) ? 100 : e.ProgressPercentage;
		}

		#endregion Constructors

		#region Event Handlers

		void BtnSettingsStop_Click(object sender, EventArgs e)
		{
			if (_mainWindowPresenter.BackgroundWorker != null)
			{
				_mainWindowPresenter.BackgroundWorker.CancelAsync();
			}
		}

		void BtnSettingsReset_Click(object sender, EventArgs e)
		{
			ResetCriteria();
		}

		void BtnSettingsStart_Click(object sender, EventArgs e)
		{
			_settingsCriteria = (PingCriteria)bsCriteria.DataSource;

			_singlePingInstance = MainWindowPresenter.ConvertPingInstance(_settingsCriteria);

			_mainWindowPresenter.PingWorker(_singlePingInstance, _settingsCriteria.NumberOfPings);

			btnSettingsStart.Text = "Busy";
			btnSettingsStart.Enabled = false;
		}

		void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnSettingsStart.Text = "Start";
			btnSettingsStart.Enabled = true;

			IList<PingInstanceReply> pingReplies = _mainWindowPresenter.PingReplies;

			bsPingReplies.DataSource = pingReplies;

			/*_pingReplyStats = (PingReplyStats)bsPingReplyStats.DataSource;

			_pingReplyStats.AverageRoundTripTime = pingReplies.Average(i => i.RoundTripTime);
			_pingReplyStats.SuccessfulPings = pingReplies.Count(i => i.Status == IPStatus.Success);

			bsPingReplyStats.DataSource = _pingReplyStats;*/

			txtAverageRoundTripTime.Text = Convert.ToString(pingReplies.Average(i => i.RoundTripTime));
			txtSuccessfulPings.Text = Convert.ToString(pingReplies.Count(i => i.Status == IPStatus.Success));
		}

		void BtnSettingsTest_Click(object sender, EventArgs e)
		{
			_settingsCriteria = (PingCriteria)bsCriteria.DataSource;

			MainWindowPresenter.IsPingCriteriaValid(_settingsCriteria);
		}

		#endregion Event Handlers
		
		#region Methods

		void ResetCriteria()
		{
			PingCriteria pingCriteria = new PingCriteria();

			bsCriteria.DataSource = pingCriteria;
		}

		#endregion Methods

	}
}
