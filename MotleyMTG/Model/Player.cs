using System.Collections.Generic;
using System.Linq;

namespace MotleyMTG
{
	public class Player
	{
		public List<MatchRecord> MatchHistory { get; set; }

		public List<Player> GetAllPriorOpponents()
		{
			return MatchHistory.Select(histMatch => histMatch.Opponent).ToList();
		}
	}
}