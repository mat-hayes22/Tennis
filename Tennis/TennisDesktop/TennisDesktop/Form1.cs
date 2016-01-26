using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisBusiness;

namespace TennisDesktop
{
    public partial class Form1 : Form
    {
        readonly Game g;
        public Form1()
        {
            InitializeComponent();
            g = new Game();
        }

        private void buttonP1_Click(object sender, EventArgs e)
        {
            g.Score(1);
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            txP1Score.Text = g.PlayerOne.ToString();
            txP2Score.Text = g.PlayerTwo.ToString();
        } 

        private void buttonP2_Click(object sender, EventArgs e)
        {
            g.Score(2);
            UpdateScreen();
        }
    }
}
