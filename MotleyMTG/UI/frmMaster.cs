using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotleyMTG
{
	public partial class frmMaster : Form
	{
        IDraftHandler draftHandler;

		public frmMaster()
		{
			InitializeComponent();

            UI.PlayerEntry ctlPlayerEntry = new UI.PlayerEntry();
            ctlPlayerEntry.PlayersSeated += CtlPlayerEntry_PlayersSeated;
            Controls.Add(ctlPlayerEntry);
		}

        private void CtlPlayerEntry_PlayersSeated(List<Player> players)
        {  
            this.Controls.RemoveAt(0);
            this.Controls.Add(new UI.ShowSeatedPlayers(players));
        }

	}
}
