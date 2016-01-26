using System;
using System.Collections.Generic;

namespace TennisBusiness
{
    public class Game
    {
        public int PlayerOne { get { return _Scores[1]; } }
        public int PlayerTwo { get { return _Scores[2]; } }

        private List<int> _Scores;
        private List<string> _Names;

        public Game()
        {
            Setup();
        }

        private void Setup()
        {
            _Scores = new List<int>();
            _Names = new List<string>();
            _Names.Add("");
            _Names.Add("Player 1");
            _Names.Add("Player 2");

            _Scores.Add(0);
            _Scores.Add(0);
            _Scores.Add(0);
        }

        public Game(int playerOneScore, int playerTwoScore)
        {
            Setup();
            _Scores[1] = playerOneScore;
            _Scores[2] = playerTwoScore;
        }

        public Game(int playerOneScore, int playerTwoScore, string playerOneName, string playerTwoName) 
        {
            Setup();
            _Scores[1] = playerOneScore;
            _Scores[2] = playerTwoScore;
            _Names[1] = playerOneName;
            _Names[2] = playerTwoName;

        }

        public void Score(int whichPlayer)
        {
            if (_Scores[GetOtherPlayer(whichPlayer)] == 50)
            {
                _Scores[GetOtherPlayer(whichPlayer)] = 40;
            }
            else
            {
                switch (_Scores[whichPlayer])
                {
                    case 50:
                        _Scores[whichPlayer] += 5;
                        break;
                    case 40:
                        _Scores[whichPlayer] += _Scores[GetOtherPlayer(whichPlayer)] == 40 ? 10 : 15;
                        break;

                    case 30:
                        _Scores[whichPlayer] += 10;
                        break;
                    default:
                        _Scores[whichPlayer] += 15;
                        break;
                }

            }
        }

        public string Scores()
        {
            return string.Format("{2} {0} - {1} {3}", _Scores[1], _Scores[2], _Names[1], _Names[2]);
        }

        public int GetOtherPlayer(int v)
        {
            return v == 1 ? 2 : 1; 
        }
    }
}