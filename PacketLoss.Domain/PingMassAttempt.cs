using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;

namespace PacketLoss.Domain
{
	public class PingMassAttempt
	{
		#region Fields

		private int _numberOfPingAttempts;

		private IList<PingInstance> _pingAttemps;

		private IList<PingInstanceReply> _pingReplies;

		#endregion Fields

		#region Properties

		public int NumberOfPingAttempts
		{
			get { return _numberOfPingAttempts; }
			set { _numberOfPingAttempts = value; }
		}

		public IList<PingInstance> PingAttempts
		{
			get { return _pingAttemps; }
			set { _pingAttemps = value; }
		}

		public IList<PingInstanceReply> PingReplies
		{
			get { return _pingReplies; }
			set { _pingReplies = value; }
		}

		#endregion Properties

		#region Constructors

		public PingMassAttempt(int numberOfPingAttemps, PingInstance pingInstance)
		{
			BackgroundWorker worker = new BackgroundWorker
			{
				WorkerSupportsCancellation = true,
				WorkerReportsProgress = true
			};

			Ping pingSender = new Ping();

			PingReply reply;

			PingReplies = new List<PingInstanceReply>();

			for (int a = 0; a < numberOfPingAttemps; a++)
			{

				reply = pingSender.Send(pingInstance.Address,
									pingInstance.TimeOut,
									pingInstance.Buffer,
									pingInstance.Options);

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
					PingReplies.Add(new PingInstanceReply
					{
						Status = reply.Status
					});
				}
			}
		}

		#endregion Constructors

		#region Methods

		public static bool IsPingValid(PingInstance pingInstance)
		{
			Ping pingSender = new Ping();

			try
			{
				pingSender.Send
					(pingInstance.Address,
					pingInstance.TimeOut,
					pingInstance.Buffer,
					pingInstance.Options);
			}
			catch
			{
				return false;
			}
			return true;
		}

		#endregion Methods

		private static void Main()
		{
			PingInstance attemp1 = new PingInstance
			{
				Address = "www.google.com",
				BufferString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
				TimeOut = 500,
				DontFragment = false,
				TimeToLive = 128
			};

			PingMassAttempt pingMassAttempt = new PingMassAttempt(100, attemp1);

			Console.WriteLine(pingMassAttempt.PingReplies.Average(i => i.RoundTripTime));

			Console.ReadKey();
		}
	}
}