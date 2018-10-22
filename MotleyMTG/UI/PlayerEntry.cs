using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotleyMTG.UI
{
    public partial class PlayerEntry : UserControl
    {

        public delegate void PlayerEntryEventHandler(List<Player> players);
        public event PlayerEntryEventHandler PlayersSeated;

        public PlayerEntry()
        {
            InitializeComponent();
        }

        private void cmdSeat_Click(object sender, EventArgs e)
        {
            List<string> playerNameList = new List<string>();
            foreach (DataGridViewRow row in dgPlayers.Rows)
            {
                string playerName = (string)row.Cells[0].FormattedValue;
                if (!string.IsNullOrEmpty(playerName)) playerNameList.Add(playerName);
            }
            List<Player> players = playerNameList.ConvertAll(name => new Player(name));
            foreach (var item in players.OrderBy(p => Guid.NewGuid()).Select((player, i) => new { i, player}))
            {
                item.player.Seat = (item.i)+1;
            }
            OnPlayersSeated(players);
        }

        private void OnPlayersSeated(List<Player> players)
        {
            PlayersSeated?.Invoke(players);
        }
    }

}
