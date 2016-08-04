using System;
using System.Collections.Generic;

namespace TennisBusiness
{
    public class Game
    {
        public Dictionary<int, int> Scores;
        private string playerOneName;
        private string playerTwoName;

        public Game(int playerOneScore, int playerTwoScore)
        {
            Scores = new Dictionary<int, int>();
            Scores.Add(1, playerOneScore);
            Scores.Add(2, playerTwoScore);
            playerOneName = "Player 1";
            playerTwoName = "Player 2";
        }

        public Game(int playerOneScore, int playerTwoScore, string playerOneName, string playerTwoName) : this(playerOneScore, playerTwoScore)
        {
            this.playerOneName = playerOneName;
            this.playerTwoName = playerTwoName;
        }

        public void ScorePoint(int whichPlayer)
        {
            int Score =0;

            if (Scores[GetOtherPlayer(whichPlayer)] == 50)
                {
                Scores[GetOtherPlayer(whichPlayer)] = 40;
            }
            else
            {
               switch (Scores[whichPlayer])
                {
                    case 50:
                        Score = 5;
                        break;

                    case 40:
                        Score = Scores[GetOtherPlayer(whichPlayer)] == 40 ? 10 : 15;
                        break;
                    case 30:
                        Score = 10;
                        break;
                    default:
                        Score = 15;
                        break;
                }
            }
            Scores[whichPlayer] += Score;
        }


        public override string ToString() => $"{playerOneName} {PlayerOneScore()} - {PlayerTwoScore()} {playerTwoName}";

        public int PlayerOneScore() => Scores[1];
        public int PlayerTwoScore() => Scores[2];

        public int GetOtherPlayer(int v) => v == 1 ? 2 : 1;
    }
}