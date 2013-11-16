

namespace PacketLoss.UI.Entity
{
	public class PingCriteria
	{
		#region Fields

		private string _address;
		private int _numberOfPings;
		private string _buffer;
		private string _timeOut;
		private bool _dontFragment;
		private string _timeToLive;

		#endregion Fields

		#region Properties

		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				_address = value;
			}
		}

		public int NumberOfPings
		{
			get
			{
				return _numberOfPings;
			}
			set
			{
				_numberOfPings = value;
			}
		}

		public string Buffer
		{
			get
			{
				return _buffer;
			}
			set
			{
				_buffer = value;
			}
		}

		public string TimeOut
		{
			get
			{
				return _timeOut;
			}
			set
			{
				_timeOut = value;
			}
		}

		public bool DontFragment
		{
			get
			{
				return _dontFragment;
			}
			set
			{
				_dontFragment = value;
			}
		}

		public string TimeToLive
		{
			get
			{
				return _timeToLive;
			}
			set
			{
				_timeToLive = value;
			}
		}
		#endregion Properties

		public PingCriteria()
		{
			Address = "www.google.com";
			NumberOfPings = 10;
		}
	}
}
