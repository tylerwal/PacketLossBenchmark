using PacketLoss.Domain;
using PacketLoss.UI.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PacketLoss.UI
{
	using System.Windows.Forms.VisualStyles;

	public class MainWindowPresenter
	{
		#region Fields

		private BackgroundWorker _backgroundWorker;

		private int _numberOfPingAttempts;
		
		private IList<PingInstanceReply> _pingReplies;

		private PingInstance _pingInstance;

		private Ping _pingSender;

		private PingReply _pingReply;

		private int _progress;

		private MainWindow _mainWindow;
		
		#endregion Fields

		#region Properties

		public BackgroundWorker BackgroundWorker
		{
			get
			{
				return _backgroundWorker;
			}
			set
			{
				_backgroundWorker = value;
			}
		}

		public IList<PingInstanceReply> PingReplies
		{
			get
			{
				return _pingReplies;
			}
			set
			{
				_pingReplies = value;
			}
		}

		public MainWindow MainWindow
		{
			get
			{
				return _mainWindow;
			}
			set
			{
				_mainWindow = value;
			}
		}

		
		
		#endregion Properties

		#region Constructors

		public MainWindowPresenter()
		{
			_backgroundWorker = new BackgroundWorker
			{
				WorkerReportsProgress = true,
				WorkerSupportsCancellation = true
			};

			_backgroundWorker.DoWork += BackgroundWorker_DoWork;
		}

		#endregion Constructors

		#region Methods

		public void BackgroundWorker_DoWork(object s, DoWorkEventArgs args)
		{
			PingReplies = new List<PingInstanceReply>();

			for (int currentPingNumber = 1; currentPingNumber <= _numberOfPingAttempts; currentPingNumber++)
			{
				//used for cancelling/stopping the ping attempt
				if (_backgroundWorker.CancellationPending)
				{
					args.Cancel = true;
					return;
				}

				PingReply reply = _pingSender.Send(_pingInstance.Address,
											_pingInstance.TimeOut,
											_pingInstance.Buffer,
											_pingInstance.Options);

				if (reply.Status == IPStatus.Success)
				{
					PingReplies.Add(new PingInstanceReply
					{
						Address = reply.Address,
						BufferLength = reply.Buffer.Length,
						DontFragment = reply.Options.DontFragment,
						RoundTripTime = reply.RoundtripTime,
						Status = reply.Status,
						TimeToLive = reply.Options.Ttl
					});
				}
				else
				{
					PingReplies.Add(
						new PingInstanceReply
						{
							Status = reply.Status
						});
				}

				//for progress bar
				_progress = (Convert.ToInt32(((decimal)currentPingNumber / (decimal)_numberOfPingAttempts) * 100) + 2);

				if (currentPingNumber == _numberOfPingAttempts)
				{
					_progress = 100;
				}

				_backgroundWorker.ReportProgress(_progress, reply);
			}
		}

		public void PingWorker(PingInstance pingInstance, int numberOfPingAttempts)
		{
			if (!IsPingInstanceValid(pingInstance))
			{
				return;
			}

			_numberOfPingAttempts = numberOfPingAttempts;

			_pingInstance = pingInstance;

			_pingSender = new Ping();

			_backgroundWorker.RunWorkerAsync();
		}

		public static PingInstance ConvertPingInstance(PingCriteria pingCriteria)
		{
			try
			{
				PingInstance pingInstance = new PingInstance
				{
					Address = pingCriteria.Address,
					BufferString = pingCriteria.Buffer ?? "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
					DontFragment = pingCriteria.DontFragment,
					TimeOut = Convert.ToInt32(pingCriteria.TimeOut ?? "1000"),
					TimeToLive = Convert.ToInt32(pingCriteria.TimeToLive ?? "120")
				};

				return pingInstance;
			}
			catch (Exception)
			{
				throw new Exception("There was a problem converting your criteria to a Ping.");
			}
		}

		private static bool IsPingInstanceValid(PingInstance pingInstance)
		{
			if (PingMassAttempt.IsPingValid(pingInstance))
			{
				return true;
			}
			MessageBox.Show(PingProblem, "Error");
			return false;
		}

		internal static void IsPingCriteriaValid(PingCriteria pingCriteria)
		{
			PingInstance pingInstance = ConvertPingInstance(pingCriteria);

			if (PingMassAttempt.IsPingValid(pingInstance))
			{
				MessageBox.Show(PingOk, "No Problems Detected");
			}
			else
			{
				MessageBox.Show(PingProblem, "Error");
			}
		}

		#endregion Methods

		#region Messages

		private const string PingProblem = "There was a problem while testing your Ping - Please check your settings.";

		private const string PingOk = "The ping attempt was succesful.";

		#endregion Messages

	}
}