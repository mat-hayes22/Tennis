using System;
using System.Collections.Generic;

namespace TennisBusiness
{
    public class Game
    {
        public int PlayerOne { get { return _scores[1]; } }
        public int PlayerTwo { get { return _scores[2]; } }

        private List<int> _scores;
        private short p0;
        private short p1;

        public Game()
        {
            _scores = new List<int>();
            _scores.Add(0);
            _scores.Add(0);
            _scores.Add(0);
        }

        public Game(short playerOneScore, short playerTwoScore)
        {
            _scores = new List<int>();
            _scores.Add(0);
            _scores.Add(0);
            _scores.Add(0);
            _scores[1] = playerOneScore;
            _scores[2] = playerTwoScore;
        }

        public void ScorePoint(int whichPlayer)
        {
            int ScoreToAdd = 15;

            if (_scores[GetOtherPlayer(whichPlayer)] == 50)
            {
                ScoreToAdd = 0;
                _scores[GetOtherPlayer(whichPlayer)] = 40;
            }
            else
            {
                switch (_scores[whichPlayer])
                {
                    case 40:
                        if (_scores[GetOtherPlayer(whichPlayer)] == 40)
                        {
                            ScoreToAdd = 10;
                        }
                        break;
                    case 50:
                        ScoreToAdd = 5;
                        break;
                    case 30:
                        ScoreToAdd = 10;
                        break;
                    default:
                        break;
                }

            }
            _scores[whichPlayer] += ScoreToAdd;
        }

        public string Scores()
        {
             return(string.Format("Player 1 {0} - {1} Player 2", _scores[1], _scores[2]));
        }

        public int GetOtherPlayer(int player)
        {
            if (player == 1) { return 2; } else return 1;
        }
    }
}