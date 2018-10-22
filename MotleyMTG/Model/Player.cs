using System.Collections.Generic;
using System.Linq;

namespace MotleyMTG
{
	public class Player
	{
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public int Seat { get; set; }
		public List<MatchRecord> MatchHistory { get; set; }

		public List<Player> GetAllPriorOpponents()
		{
			return MatchHistory.Select(histMatch => histMatch.Opponent).ToList();
		}

		public int MatchPoints()
		{
			return MatchHistory.Sum(histMatch => histMatch.MatchPoints());
		}
	}
}