using System;

namespace TennisBusiness
{
    public class Game
    {
        private int Player1;
        private int Player2;

        public Game(int v1, int v2)
        {
            this.Player1 = v1;
            this.Player2 = v2;
        }

        public int PlayerOneScore { get { return Player1; } }

        public void ScorePoint(int v)
        {
            Player1 += 15;
        }
        
        public override string ToString()
        {
            return string.Format("Player One {0} - 0 Player Two", Player1);
        }
    }
}