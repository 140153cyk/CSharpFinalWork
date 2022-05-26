using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAndGuess
{
    public partial class WaitingRoomForm : Form
    {
        Client client;
        public WaitingRoomForm(Client c)
        {
            client = c;
            InitializeComponent();
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            client.Prepare();
        }
    }
}
