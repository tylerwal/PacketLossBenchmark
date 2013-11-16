namespace PacketLoss.UI.Entity
{
	public class PingReplyStats
	{
		#region Fields

		private double? _averageRoundTripTime;

		private int _successfulPings;
		
		#endregion Fields

		#region Properties

		public double? AverageRoundTripTime
		{
			get
			{
				return _averageRoundTripTime;
			}
			set
			{
				_averageRoundTripTime = value;
			}
		}

		public int SuccessfulPings
		{
			get
			{
				return _successfulPings;
			}
			set
			{
				_successfulPings = value;
			}
		}
		
		#endregion Properties

		#region Constructors

		public PingReplyStats()
		{
			
		}

		#endregion Constructors

		#region Methods



		#endregion Methods

		#region Helper Methods



		#endregion Helper Methods
	}
}