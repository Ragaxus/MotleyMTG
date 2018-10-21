using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotleyMTG.Model
{
	public class SwissPairingStrategy : IPairingStrategy
	{
		public PairingList AssignPairings(List<Player> players)
		{
			List<PairingList> allPossiblePairingLists = GetAllPossiblePairs(players).Cast<PairingList>().ToList();
			return BestPairingList(allPossiblePairingLists);
		}



		public static List<List<Tuple<T, T>>> GetAllPossiblePairs<T>(List<T> items)
		{
			List<List<Tuple<T, T>>> allPairingsLists = new List<List<Tuple<T, T>>>();
			GetAllPossiblePairsInternal(items, new List<Tuple<T, T>>(), ref allPairingsLists);
			return allPairingsLists;
		}

		private static void GetAllPossiblePairsInternal<T>(List<T> items, List<Tuple<T, T>> currentPairingList, ref List<List<Tuple<T, T>>> allPairingsLists)
		{
			if (items.Count == 0) allPairingsLists.Add(currentPairingList);
			else
			{
				var itemsCopy = new List<T>(items);
				T firstItem = itemsCopy[0];
				itemsCopy.RemoveAt(0);
				for (int i = 0; i < itemsCopy.Count; i++)
				{
					var itemsSecondCopy = new List<T>(itemsCopy);
					T secondItem = itemsSecondCopy[i];
					itemsSecondCopy.RemoveAt(i);
					List<Tuple<T, T>> newPairingList = new List<Tuple<T, T>>(currentPairingList);
					newPairingList.Add(new Tuple<T, T>(firstItem, secondItem));
					GetAllPossiblePairsInternal(itemsSecondCopy, newPairingList, ref allPairingsLists);
				}
			}

		}


		private PairingList BestPairingList(List<PairingList> allPossiblePairingLists)
		{
			return allPossiblePairingLists.OrderBy(pairingList => CalculatePairingCost(pairingList)).First();
		}

		public int CalculatePairingCost(PairingList pairingList)
		{
			int cost = 0;
			foreach (Match pair in (List<Match>)pairingList)
			{
				if (pair.HaveAlreadyPlayed()) cost += 1000000;
				else
				{
					int diff = pair.Player1.MatchPoints() - pair.Player2.MatchPoints();
					cost += diff * diff;
				};
			}
			return cost;
		}
	}
}
