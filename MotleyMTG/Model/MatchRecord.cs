namespace MotleyMTG
{
	public class MatchRecord
	{
		public Player Opponent { get; set; }
		public int NumberOfWins { get; set; }
		public int NumberOfLosses { get; set; }
		public int NumberOfDraws { get; set; }

		public int MatchPoints()
		{
			int outcome = NumberOfWins - NumberOfLosses;
			if (outcome > 0) return 3;
			else if (outcome == 0) return 1;
			else return 0;
		}
	}
}