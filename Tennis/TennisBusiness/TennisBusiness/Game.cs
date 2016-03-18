using System;
using System.Collections.Generic;

namespace TennisBusiness
{
    public class Game
    {

        private Dictionary<int, int> PlayerScores;
        private Dictionary<int, string> PlayerNames;

        public Game(string p1Name, string p2Name, int p1Score, int p2Score)
        {
            PlayerScores = new Dictionary<int, int> { { 1, p1Score }, { 2, p2Score } };
            PlayerNames = new Dictionary<int, string> { { 1, p1Name}, { 2, p2Name} };
        }

        
        public int PlayerOneScore { get { return PlayerScores[1]; } }
        public int PlayerTwoScore { get { return PlayerScores[2]; } }

        public void ScorePoint(int whichPlayer)
        {

            int PointsToAdd = 0;

            if (PlayerScores[GetOtherPlayer(whichPlayer)] == 50)
            {
                PlayerScores[GetOtherPlayer(whichPlayer)] = 40;
            }
            else
            {
                switch (PlayerScores[whichPlayer])
                {
                    case 50:
                        PointsToAdd = 5;
                        break;
                    case 40:
                        PointsToAdd = (PlayerScores[GetOtherPlayer(whichPlayer)] == 40) ? 10 : 15;
                        break;
                    case 30:
                        PointsToAdd = 10;
                        break;

                    default:
                        PointsToAdd = 15;
                        break;
                }

            }

            PlayerScores[whichPlayer] += PointsToAdd;        
        }

        public override string ToString() => $"{PlayerNames[1]} {PlayerOneScore} - {PlayerTwoScore} {PlayerNames[2]}";

        private int GetOtherPlayer(int whichPlayer)
        {
            return (whichPlayer == 1) ? 2 : 1;
        }
    }
}