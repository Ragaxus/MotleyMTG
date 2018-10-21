using System.Collections.Generic;

namespace MotleyMTG.Model
{
	public struct PairingList
	{
		private List<Match> _matches;

		internal PairingList(List<Match> matches)
		{
			_matches = matches;
		}

		public static implicit operator List<Match>(PairingList matches)
		{
			return matches._matches;
		}
	}
}