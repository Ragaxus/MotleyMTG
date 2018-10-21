using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotleyMTG.Model
{
	interface IPairingStrategy
	{
		PairingList AssignPairings(List<Player> players);
	}
}
