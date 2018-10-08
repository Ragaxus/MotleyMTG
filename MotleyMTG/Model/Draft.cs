using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotleyMTG.Model
{
	public class Draft
	{
		public List<Player> Players { get; set; }
		public int CurrentRound { get; set; }
		public PairingList AssignPairings()

		{
			IPairingStrategy strategy;
			List<Player> playersCopy = new List<Player>(Players);
			if (playersCopy.Count % 2 == 1)
			{
				Player byePlayer = ThrowOutByePlayer(ref playersCopy);
				Match byeMatch = MakeByeMatch(byePlayer);
			}
			if (CurrentRound == 1) strategy = new SeatingPairingStrategy();
			else strategy = new SwissPairingStrategy();
			return strategy.AssignPairings(playersCopy);
		}

		private Player ThrowOutByePlayer(ref List<Player> playersCopy)
		{
			throw new NotImplementedException();
		}

		private Match MakeByeMatch(Player byePlayer)
		{
			throw new NotImplementedException();
		}
	}
}
