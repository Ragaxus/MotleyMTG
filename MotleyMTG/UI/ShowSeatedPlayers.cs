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
    public partial class ShowSeatedPlayers : UserControl
    {
        public ShowSeatedPlayers(List<Player> players)
        {
            InitializeComponent();
            var list = new BindingList<Player>(players.OrderBy(player => player.Name).ToList());
            dgSeatedPlayers.DataSource = list;
        }
    }
}
