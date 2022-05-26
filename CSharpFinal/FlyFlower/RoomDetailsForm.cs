using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyFlower
{
    public partial class RoomDetailsForm : Form
    {
        public string roomName { get; set; }
        public int maxMem { get; set; } = 10;
        public RoomDetailsForm()
        {
            InitializeComponent();
            txtRoomName.DataBindings.Add("Text", this, "roomName");
            txtMaxMem.DataBindings.Add("Text", this, "maxMem");
        }
    }
}
