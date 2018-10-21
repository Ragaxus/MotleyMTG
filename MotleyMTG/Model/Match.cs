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

		internal bool HaveAlreadyPlayed()
		{
			return _match.Item1.GetAllPriorOpponents().Contains(_match.Item2);
		}

		internal Player Player1
		{
			get { return _match.Item1; }
		}

		internal Player Player2
		{
			get { return _match.Item2; }
		}
	}
}