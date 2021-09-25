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
        // Button Event to show Heads when you click on the heads button.
        private void btnShowHeads_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Heads1;
        }
        // Button Event to show Tails when you click on the tails button.
        private void btnShowTails_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Tails1;
        }
        // Button Event to reset the coin graphic to a default neutral one.
        private void Reset_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources._10cents;
        }

    }
}
