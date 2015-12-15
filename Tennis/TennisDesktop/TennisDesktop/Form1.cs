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
        Game _g = new Game();

        public Form1()
        {
            InitializeComponent();
            txP1Score.Text = _g.PlayerOne.ToString();
            txP2Score.Text = _g.PlayerTwo.ToString();

        }

        private void buttonP1_Click(object sender, EventArgs e)
        {
            _g.ScorePoint(1);
            txP1Score.Text = _g.PlayerOne.ToString();
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            _g.ScorePoint(2);
            txP2Score.Text = _g.PlayerTwo.ToString();

        }
    }
}
