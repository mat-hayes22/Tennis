using System;

namespace TennisBusiness
{
    public class Game
    {
        private int v1;
        private int v2;

        public Game(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int PlayerOneScore { get; set; }

        public void ScorePoint(int v)
        {
            throw new NotImplementedException();
        }
    }
}