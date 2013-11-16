using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PacketLoss.Domain;
using PacketLoss.Entity;

namespace PacketLoss
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		#region Fields

		private BackgroundWorker _backgroundWorker;

		private int _numberOfPingAttempts;

		private IList<PingInstance> _pingAttemps;

		private IList<PingInstanceReply> _pingReplies;

		private PingInstance _pingInstance;

		private PingCriteria _pingCriteria;

		private Binding _bsBinding;

		#endregion Fields

		#region Properties

		#endregion Properties

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();

			//binding
			_pingCriteria = new PingCriteria();

			_bsBinding = new Binding();
			_bsBinding.Source = _pingCriteria;

			#region Event Handler Declaration

			btnPing.Click += btnPing_Click;
			btnReset.Click += btnReset_Click;
			btnCancel.Click += BtnCancelOnClick;

			#endregion Event Handler Declaration
		}

		#endregion Constructors


		#region Event Handlers

		void btnPing_Click(object sender, RoutedEventArgs e)
		{
			_pingCriteria = (PingCriteria)_bsBinding.Source;

			_pingInstance = convertPingInstance(_pingCriteria);

			if (PingCore.IsPingValid(_pingInstance))
			{
				PingWorker();
			}
			else
			{
				MessageBox.Show("The ping was not valid.","Error");
			}
		}

		void btnReset_Click(object sender, RoutedEventArgs e)
		{
			ClearCriteria();
		}

		private void BtnCancelOnClick(object sender, RoutedEventArgs routedEventArgs)
		{
			if (_backgroundWorker != null)
			{
				_backgroundWorker.CancelAsync(); 
			}
		}

		#endregion Event Handlers

		#region Delegates

		

		#endregion Delegates

		#region Methods

		void PingWorker()
		{
			_backgroundWorker = new BackgroundWorker
			{
				WorkerReportsProgress = true,
				WorkerSupportsCancellation = true
			};

			_backgroundWorker.DoWork += delegate(object s, DoWorkEventArgs args)
			{
				//used for cancelling/stopping the ping attempt
				if (_backgroundWorker.CancellationPending)
				{
					args.Cancel = true;
					return;
				}

				//ping attempt


				//for progress bar
				_backgroundWorker.ReportProgress(12);
			};

			_backgroundWorker.ProgressChanged += delegate(object s, ProgressChangedEventArgs args)
			{
				int percentageDone = args.ProgressPercentage;
			};

			//runs the ping process
			_backgroundWorker.RunWorkerAsync();

		}

		void ClearCriteria()
		{
			
		}

		private static PingInstance convertPingInstance(PingCriteria _pingCriteria)
		{
			PingInstance pingInstance = new PingInstance()
			{
				Address = _pingCriteria.Address,
				BufferString = _pingCriteria.Buffer,
				DontFragment = _pingCriteria.DontFragment,
				TimeOut = Convert.ToInt32(_pingCriteria.TimeOut),
				TimeToLive =  Convert.ToInt32(_pingCriteria.TimeToLive)
			};

			return pingInstance;
		}

		#endregion Methods

		void crap()
		{
			PingInstance attemp1 = new PingInstance
			{
				Address = "www.google.com",
				BufferString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
				TimeOut = 500,
				DontFragment = false,
				TimeToLive = 128
			};

			PingMassAttempt pingMassAttempt = new PingMassAttempt(20, attemp1);
		}
	}
}
