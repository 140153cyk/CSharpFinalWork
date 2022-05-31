using ImportData;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic
{
    public partial class PoemDetail : Form
    {
        private Poem poem;
        public PoemDetail(Poem poem)
        {
            this.poem = poem;
            InitializeComponent();
        }
    }
}
