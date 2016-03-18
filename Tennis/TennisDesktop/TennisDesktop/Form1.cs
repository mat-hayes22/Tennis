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

        Game g;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePoints(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePoints(1);
        }

        private void UpdatePoints(int v)
        {
            g.ScorePoint(v);
            numericUpDown1.Value = g.PlayerOneScore;
            numericUpDown2.Value = g.PlayerTwoScore;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = new Game(txP1Name.Text, txP2Name.Text, 0,0);
        }
    }
}
