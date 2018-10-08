namespace MotleyMTG
{
	public class MatchRecord
	{
		public Player Opponent { get; set; }
		public int NumberOfWins { get; set; }
		public int NumberOfLosses { get; set; }
		public int NumberOfDraws { get; set; }
	}
}