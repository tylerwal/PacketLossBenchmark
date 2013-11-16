using System;
using PacketLoss.Domain;
using System.Linq;

namespace PacketLoss.ConsoleBased
{
	class ConsoleEntryPoint
	{
		static void Main()
		{
			Console.Write("Address to ping: ");
			string address = Console.ReadLine();
			address = (address == string.Empty) ? "www.google.com" : address;

			Console.Write("Number of Pings: ");
			int numberOfPings = ReadConvertToIntOrDefault(10);

			Console.Write("Buffer String (leave blank for default): ");
			string buffer = Console.ReadLine() ?? "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

			Console.Write("TimeOut in milleseconds (leave blank for default): ");
			int timeOut = ReadConvertToIntOrDefault(1000);

			Console.Write("Don't Fragment ('T'rue or 'F'alse*): ");
			bool dontFragment = (Console.ReadLine() == "T");

			Console.Write("Time To Live in milleseconds (leave blank for default): ");
			int timeToLive = ReadConvertToIntOrDefault(128);

			PingInstance pingInstance = new PingInstance
			{
				Address = address,
				BufferString = buffer,
				TimeOut = timeOut,
				DontFragment = dontFragment,
				TimeToLive = timeToLive
			};

			PingMassAttempt pingMassAttempt = new PingMassAttempt(numberOfPings, pingInstance);

			Console.WriteLine("\nAverage Ping Time in Milleseconds: {0}", pingMassAttempt.PingReplies.Average(i => i.RoundTripTime));

			Console.ReadKey();
		}

		#region Methods

		private static int ReadConvertToIntOrDefault(int defaultValue)
		{
			string beforeConvert = Console.ReadLine();
			return (beforeConvert == string.Empty) ? defaultValue : Convert.ToInt32(beforeConvert);
		}

		#endregion Methods
	}
}
