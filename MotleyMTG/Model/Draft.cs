using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotleyMTG
{
	public class Draft
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

		private List<Match> AssignPairingsBySwiss(List<Player> players)
		{
            //Array.ConvertAll(array, item => (NewType)item);
            List<List<Tuple<Player,Player>>> allPossPairsAsTuples = GetAllPossiblePairs(players);
            List<List<Match>> allPossiblePairingLists = new List<List<Match>>();
			return BestPairingList(allPossiblePairingLists);
		}

		public static List<List<Tuple<T,T>>> GetAllPossiblePairs<T>(List<T> items)
		{
            List<List<Tuple<T, T>>> allPairingsLists = new List<List<Tuple<T, T>>>();
            GetAllPossiblePairsInternal(items, new List<Tuple<T, T>>(), ref allPairingsLists);
            return allPairingsLists;
		}

        private static void GetAllPossiblePairsInternal<T>(List<T> items, List<Tuple<T,T>> currentPairingList, ref List<List<Tuple<T, T>>> allPairingsLists)
        {
            if (items.Count == 0) allPairingsLists.Add(currentPairingList);
            else
            {
                var itemsCopy = new List<T>(items);
                T firstItem = itemsCopy[0];
                itemsCopy.RemoveAt(0);
                for (int i=0; i < itemsCopy.Count; i++)
                {
                    var itemsSecondCopy = new List<T> (itemsCopy);
                    T secondItem = itemsSecondCopy[i];
                    itemsSecondCopy.RemoveAt(i);
                    List<Tuple<T, T>> newPairingList = new List<Tuple<T, T>>(currentPairingList);
                    newPairingList.Add(new Tuple<T, T>(firstItem, secondItem));
                    GetAllPossiblePairsInternal(itemsSecondCopy, newPairingList, ref allPairingsLists);
                }
            }

        }


        private List<Match> BestPairingList(List<List<Match>> allPossiblePairingLists)
		{
			throw new NotImplementedException();
		}
	}
}
