using System;
using System.Collections.Generic;

namespace TennisBusiness
{
    public class Game
    {

        public Dictionary<int,int> Scores;
        public Dictionary<int, string> Names;


        public Game(int p0, int p1)
        {
            Scores = new Dictionary<int, int>();
            Names = new Dictionary<int, string>();
            Scores.Add(1,p0);
            Scores.Add(2, p1);
            Names.Add(1, "Player 1");
            Names.Add(2, "Player 2");
        }

        public Game(int p0, int p1, string p1Name, string p2Name) : this(p0, p1)
        {
            Names[1] = p1Name;
            Names[2] = p2Name;

        }

        public void ScorePoint(int whichPlayer)
        {
            int PointScored = 0;

            if (Scores[GetOtherPlayer(whichPlayer)]== 50)
            {
                Scores[GetOtherPlayer(whichPlayer)] = 40;
            }
            else
            {
                switch (Scores[whichPlayer])
                {
                    case 50:
                        PointScored = 5;
                        break;
                    case 40:
                        if (Scores[GetOtherPlayer(whichPlayer)] == 40)
                        { PointScored = 10; }
                        else { PointScored = 15; }

                        break;
                    case 30:
                        PointScored = 10;
                        break;
                    default:
                        PointScored = 15;
                        break;
                }


            }


            Scores[whichPlayer] += PointScored;
        }

        public override string ToString() => $"{Names[1]} {Scores[1]} - {Scores[2]} {Names[2]}";

        private int GetOtherPlayer(int v)
        {
            return v == 1 ? 2 : 1;
        }
    }  
            
            
}