using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotleyMTG
{
	class Draft
	{
		public List<Player> Players { get; set; }
		public int CurrentRound { get; set; }
		public List<Match> AssignPairings()
		{
			List<Match> matches;
			List<Player> playersCopy = new List<Player>(Players);
			if (playersCopy.Count % 2 == 1)
			{
				Player byePlayer = ThrowOutByePlayer(ref playersCopy);
				Match byeMatch = MakeByeMatch(byePlayer);
			}
			if (CurrentRound == 1) matches = AssignPairingsBySeating(playersCopy);
			else matches = AssignPairingsBySwiss(playersCopy);
			return matches;
		}

		private Player ThrowOutByePlayer(ref List<Player> playersCopy)
		{
			throw new NotImplementedException();
		}

		private Match MakeByeMatch(Player byePlayer)
		{
			throw new NotImplementedException();
		}

		private List<Match> AssignPairingsBySeating(List<Player> playersCopy)
		{
			throw new NotImplementedException();
		}

		private List<Match> AssignPairingsBySwiss(List<Player> playersCopy)
		{
			List<List<Match>> allPossiblePairingLists = GetAllPossiblePairings(playersCopy);
			return BestPairingList(allPossiblePairingLists);
		}

		private static List<List<Tuple<T,T>>> GetAllPossiblePairs<T>(List<T> items)
		{
			
		}

		private List<Match> BestPairingList(List<List<Match>> allPossiblePairingLists)
		{
			throw new NotImplementedException();
		}
	}
}
