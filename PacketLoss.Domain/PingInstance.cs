using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PacketLoss.Domain
{
	public class PingInstance
	{
		#region Fields

		private string _address;
		private int _timeOut;
		private string _bufferString;
		private int _timeToLive;
		private bool _dontFragment;
		
		#endregion Fields		
		
		#region Properties
		
		[Required]
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

		public int TimeOut
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

		public string BufferString
		{
			get
			{
				return _bufferString;
			}
			set
			{
				_bufferString = value;
			}
		}

		public byte[] Buffer
		{
			get
			{
				return ConvertStringToBuffer(BufferString);
			}
		}

		public int TimeToLive
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

		public PingOptions Options
		{
			get
			{
				PingOptions options = new PingOptions
				{
					DontFragment = _dontFragment, 
					Ttl = _timeToLive
				};

				return options;
			}
		}
		
		#endregion Properties

		#region Methods

		private byte[] ConvertStringToBuffer(String data)
		{
			return Encoding.ASCII.GetBytes(data);
		}

		#endregion Methods

		#region Constuctor

		public PingInstance()
		{
			_address = String.Empty;
			_timeOut = 1000;
			_bufferString = String.Empty;
			_timeToLive = 128;
			_dontFragment = true;
		}

		#endregion Constuctor
	}
}
