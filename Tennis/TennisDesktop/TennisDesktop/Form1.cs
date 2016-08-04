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
        Game _g;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScorePoint(1);
        }

        private void ScorePoint(int whichPlayer)
        {
            int p1Score, p2Score;

            int.TryParse(txP1Score.Text, out p1Score);
            int.TryParse(txP2Score.Text, out p2Score);
            _g = new Game(p1Score, p2Score);
            _g.ScorePoint(whichPlayer);
            txP1Score.Text = _g.PlayerOneScore().ToString();
            txP2Score.Text = _g.PlayerTwoScore().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScorePoint(2);
        }
    }
}
