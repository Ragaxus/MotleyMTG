using System;

namespace MotleyMTG
{
	public class Match : Tuple<Player, Player>
	{
		public Match(Player item1, Player item2) : base(item1, item2)
		{
		}
	}
}