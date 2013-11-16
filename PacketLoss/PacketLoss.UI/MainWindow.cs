using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketLoss.Domain;
using PacketLoss.UI.Entity;

namespace PacketLoss.UI
{
	public partial class MainWindow : Form
	{

		#region Fields

		private PingCriteria _pingCriteria;

		private PingInstance _pingInstance;

		private MainWindowPresenter _mainWindowPresenter;

		#endregion Fields

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();

			_pingCriteria = new PingCriteria();
			_mainWindowPresenter = new MainWindowPresenter();
			bsCriteria.DataSource = _pingCriteria;

			#region Event Handler Declaration

			btnSettingsStart.Click += btnSettingsStart_Click;
			btnSettingsReset.Click += BtnSettingsResetOnClick;
			btnSettingsCancel.Click += btnSettingsCancel_Click;

			#endregion Event Handler Declaration
			
		}

		#endregion Constructors

		#region Event Handlers

		void btnSettingsCancel_Click(object sender, EventArgs e)
		{
			if (_mainWindowPresenter.BackgroundWorker != null)
			{
				_mainWindowPresenter.BackgroundWorker.CancelAsync();
			}
		}

		void BtnSettingsResetOnClick(object sender, EventArgs eventArgs)
		{
			ClearCriteria();
		}

		void btnSettingsStart_Click(object sender, EventArgs e)
		{
			_pingCriteria = (PingCriteria)bsCriteria.DataSource;

			_pingInstance = MainWindowPresenter.ConvertPingInstance(_pingCriteria);

			_mainWindowPresenter.PingWorker(_pingInstance);
		}

		#endregion Event Handlers
		
		#region Methods

		void ClearCriteria()
		{
			
		}

		#endregion Methods
	}
}
