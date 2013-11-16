using System.Net;
using System.Net.NetworkInformation;

namespace PacketLoss.Domain
{
	public class PingInstanceReply
	{

		#region Fields

		private IPStatus _status;
		private IPAddress _address;
		private long? _roundTripTime;
		private int? _timeToLive;
		private bool _dontFragment;
		private int? _bufferLength;

		#endregion Fields

		#region Properties

		public IPStatus Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public IPAddress Address
		{
			get { return _address; }
			set { _address = value; }
		}

		public long? RoundTripTime
		{
			get { return _roundTripTime; }
			set { _roundTripTime = value; } 
		}

		public int? TimeToLive
		{
			get { return _timeToLive; }
			set { _timeToLive = value; } 
		}

		public bool DontFragment
		{
			get { return _dontFragment; }
			set { _dontFragment = value; } 
		}

		public int? BufferLength
		{
			get { return _bufferLength; }
			set { _bufferLength = value; } 
		}

		#endregion Properties

		#region Constructor

		public PingInstanceReply()
		{
			Address = IPAddress.Parse("0.0.0.0");
			BufferLength = null;
			DontFragment = false;
			RoundTripTime = null;
			Status = IPStatus.Unknown;
			TimeToLive = null;
		}

		#endregion Constructor
	}
}
