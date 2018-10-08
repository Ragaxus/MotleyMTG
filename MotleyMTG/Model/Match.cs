using System;

namespace MotleyMTG.Model
{
	public struct Match
	{
		private Tuple<Player, Player> _match;

		internal Match(Tuple<Player,Player> match)
		{
			_match = match;
		}

		public static implicit operator Tuple<Player, Player>(Match match)
		{
			return match._match;
		}
	}
}