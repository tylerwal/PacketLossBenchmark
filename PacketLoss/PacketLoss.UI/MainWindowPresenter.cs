using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using PacketLoss.Domain;
using PacketLoss.UI.Entity;

namespace PacketLoss.UI
{
	public class MainWindowPresenter
	{
		#region Fields

		private BackgroundWorker _backgroundWorker;

		private int _numberOfPingAttempts;

		private IList<PingInstance> _pingAttempts;

		private IList<PingInstanceReply> _pingReplies;

		private PingInstance _pingInstance;

		private PingCriteria _pingCriteria;
		
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

		public IList<PingInstance> PingAttempts
		{
			get
			{
				return _pingAttempts;
			}
			set
			{
				_pingAttempts = value;
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

		public PingCriteria PingCriteria
		{
			get
			{
				return _pingCriteria;
			}
			set
			{
				_pingCriteria = value;
			}
		}
		
		#endregion Properties

		#region Constructors

		 

		#endregion Constructors

		#region Methods

		public void PingWorker(PingInstance pingInstance)
		{
			if (!TestPingInstnace(pingInstance))
			{
				return;
			}
			
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

		public static PingInstance ConvertPingInstance(PingCriteria pingCriteria)
		{
			try
			{

				PingInstance pingInstance = new PingInstance()
				{
					Address = pingCriteria.Address,
					BufferString = pingCriteria.Buffer,
					DontFragment = pingCriteria.DontFragment,
					TimeOut = Convert.ToInt32(pingCriteria.TimeOut),
					TimeToLive = Convert.ToInt32(pingCriteria.TimeToLive)
				};

				return pingInstance;
			}
			catch (Exception)
			{
				throw new Exception("There was a problem converting your criteria to a Ping.");
			}
		}

		private static bool TestPingInstnace(PingInstance pingInstance)
		{
			if (PingMassAttempt.IsPingValid(pingInstance))
			{
				return true;
			}
			else
			{
				MessageBox.Show(PingProblem, "Error");
				return false;
			}
		}

		#endregion Methods

		#region Messages

		private const string PingProblem = "There was a problem while testing your Ping - Please check your settings.";

		#endregion Messages

	}
}