using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisBusiness;

namespace TennisTest
{
    [TestClass]
    public class GameTest
    {
        Game g;


        [TestInitialize]
        public void Setup()
        {
            g = new Game();

        }

        [TestMethod]
        public void PlayerOneNewGameStartsWithZero()
        {
            Assert.AreEqual(0, g.PlayerOne);
        }

        [TestMethod]
        public void PlayerTwoNewGameStartsWithZero()
        {
            Assert.AreEqual(0, g.PlayerTwo);
        }

        [TestMethod]
        public void AtZeroZeroNextScoreShouldBe15()
        {
            ScorePoints(1, 1);
            Assert.AreEqual(15, g.PlayerOne);
        }

        [TestMethod]
        public void At15ZeroNextScoreShouldBe30()
        {
            ScorePoints(1, 2);
            Assert.AreEqual(30, g.PlayerOne);

        }

        [TestMethod]
        public void At30ZeroNextScoreShouldBe40()
        {
            ScorePoints(1, 3);
            Assert.AreEqual(40, g.PlayerOne);

        }

        private void ScorePoints(int whichPlayer, int numberOfPoints)
        {
            for (int i = 0; i < numberOfPoints; i++)
            {
                g.Score(whichPlayer);
            }
        }

        [TestMethod]
        public void At40ZeroNextScoreShouldBe55()
        {
            ScorePoints(1, 4);
            Assert.AreEqual(55, g.PlayerOne);

        }

        [TestMethod]
        public void GivePlayerOneGetPlayerTwo()
        {
            Assert.AreEqual(2, g.GetOtherPlayer(1));
        }

        [TestMethod]
        public void GivePlayerTwoGetPlayerOne()
        {
            Assert.AreEqual(1, g.GetOtherPlayer(2));
        }

        [TestMethod]
        public void At4040NextScoreShouldBe50()
        {
            ScorePoints(2, 3);//40
            ScorePoints(1, 4); //50
            Assert.AreEqual(50, g.PlayerOne);

        }

        [TestMethod]
        public void At4050PlayerOneNextScoreShouldBe40()
        {
            ScorePoints(2, 3);//40
            ScorePoints(1, 4); //50
            ScorePoints(2, 1);//40

            Assert.AreEqual(40, g.PlayerOne);

        }

        [TestMethod]
        public void At4050NextScoreOtherPlayersScoureShouldBe55()
        {
            ScorePoints(2, 3);//40
            ScorePoints(1, 5); //55
            Assert.AreEqual(55, g.PlayerOne);

        }

        //[TestMethod]
        //public void ScoreShouldShowPlayerOneScoreDashScorePlayerTwo()
        //{
        //    Assert.Inconclusive();

        //}

        #region NonTests
        #endregion



    }
}
