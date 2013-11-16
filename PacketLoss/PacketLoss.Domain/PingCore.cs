using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PacketLoss.Domain
{
	public class PingCore
	{


		#region Methods

		public static bool IsPingValid(PingInstance pingInstance)
		{
			Ping pingSender = new Ping();

			try
			{
				pingSender.Send
					(
					pingInstance.Address,
					pingInstance.TimeOut,
					pingInstance.Buffer,
					pingInstance.Options
					);
			}
			catch
			{
				return false;
			}
			return true;
		}

		#endregion Methods
	}
}
