using System;
using System.Collections.Generic;

namespace TennisBusiness
{
    public class Game
    {
        public int PlayerOne { get { return _Scores[1]; } }
        public int PlayerTwo { get { return _Scores[2]; } }

        private List<int> _Scores;
        private short p0;
        private short p1;

        public Game()
        {
            Setup();
        }

        private void Setup()
        {
            _Scores = new List<int>();
            _Scores.Add(0);
            _Scores.Add(0);
            _Scores.Add(0);
        }

        public Game(short playerOneScore, short playerTwoScore)
        {
            Setup();
            _Scores[1] = playerOneScore;
            _Scores[2] = playerTwoScore;
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
                        if (_Scores[GetOtherPlayer(whichPlayer)] == 40)
                        {
                            _Scores[whichPlayer] += 10;
                        }
                        else
                        {
                            _Scores[whichPlayer] += 15;

                        }
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
            return string.Format("Player 1 {0} - {1} Player 2", _Scores[1], _Scores[2]);
        }

        public int GetOtherPlayer(int v)
        {
            if (v == 1) { return 2; } else { return 1; };
        }
    }
}