using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisBusiness;

namespace TennisTest
{
    [TestClass]
    public class GameTest
    {
        Game _g;

        [TestInitialize]
        public void Setup()
        {
            _g = new Game();

        }

        [TestMethod]
        public void PlayerOneNewGameStartsWithZero()
        {
            Assert.AreEqual(0, _g.PlayerOne);
        }

        [TestMethod]
        public void PlayerTwoNewGameStartsWithZero()
        {
            Assert.AreEqual(0, _g.PlayerTwo);
        }

        [TestMethod]
        public void AtZeroZeroNextScoreShouldBe15()
        {
            _g.ScorePoint(1);
            Assert.AreEqual(15, _g.PlayerOne);
        }

        [TestMethod]
        public void At15ZeroNextScoreShouldBe30()
        {
            ScorePoint(1,2);
            Assert.AreEqual(30, _g.PlayerOne);
        }

        [TestMethod]
        public void At30ZeroNextScoreShouldBe40()
        {
            ScorePoint(1, 3);
            Assert.AreEqual(40, _g.PlayerOne);

        }

        [TestMethod]
        public void At40ZeroNextScoreShouldBe55()
        {
            ScorePoint(1, 4);
            Assert.AreEqual(55, _g.PlayerOne);

        }

        [TestMethod]
        public void GivePlayerOneGetPlayerTwo()
        {
            Assert.AreEqual(2, _g.GetOtherPlayer(1));

        }

        [TestMethod]
        public void GivePlayerTwoGetPlayerOne()
        {
            Assert.AreEqual(1, _g.GetOtherPlayer(2));

        }

        [TestMethod]
        public void At4040NextScoreShouldBe50()
        {
            ScorePoint(2, 3);
            ScorePoint(1, 4);
            Assert.AreEqual(50, _g.PlayerOne);

        }

        [TestMethod]
        public void At4050PlayerOneNextScoreShouldBe40()
        {
            ScorePoint(1, 3); // 40
            ScorePoint(2, 4); // 50
            ScorePoint(1, 1); // 40
            Assert.AreEqual(40, _g.PlayerOne);
        }

        [TestMethod]
        public void At4050NextScoreOtherPlayersScoureShouldBe55()
        {
            ScorePoint(2, 3); // 40
            ScorePoint(1, 5); // 55
            Assert.AreEqual(55, _g.PlayerOne);

        }

        //[TestMethod]
        //public void ScoreShouldShowPlayerOneScoreDashScorePlayerTwo()
        //{
        //    Assert.Inconclusive();

        //}

        #region NonTests

        private void ScorePoint(int whichPlayer, int numberOfPoints)
        {
            for (int i = 0; i < numberOfPoints; i++)
            {
                _g.ScorePoint(whichPlayer);
            }
        }

        #endregion



    }
}
