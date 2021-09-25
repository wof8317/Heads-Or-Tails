using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsOrTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTailsCount_Click(object sender, EventArgs e)
        {

        }

        private void btnShowHeads_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Heads1;
        }

        private void btnShowTails_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Tails1;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources._10cents;
        }

    }
}
