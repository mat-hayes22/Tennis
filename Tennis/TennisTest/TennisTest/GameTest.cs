using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisBusiness;

namespace TennisTest
{
    [TestClass]
    public class GameTest
    {
        Game _g;

        //[TestInitialize]
        //public void Setup()
        //{
        //}

        [TestMethod]
        public void PlayerOneNewGameStartsWithZero()
        {
            Game _g = new Game(0, 0);
            Assert.AreEqual(0, _g.PlayerOneScore());
        }

        [TestMethod]
        public void PlayerTwoNewGameStartsWithZero()
        {
            _g = new Game(0, 0);
            Assert.AreEqual(0, _g.PlayerTwoScore());
        }

        [TestMethod]
        public void AtZeroZeroNextScoreShouldBe15()
        {
            _g = new Game(0, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(15, _g.PlayerOneScore());
        }

        [TestMethod]
        public void At15ZeroNextScoreShouldBe30()
        {
            _g = new Game(15, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(30, _g.PlayerOneScore());

        }

        [TestMethod]
        public void At30ZeroNextScoreShouldBe40()
        {
            _g = new Game(30, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(40, _g.PlayerOneScore());
        }

        [TestMethod]
        public void At40ZeroNextScoreShouldBe55()
        {
            _g = new Game(40, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(55, _g.PlayerOneScore());

        }

        [TestMethod]
        public void At4040NextScoreShouldBe50()
        {
            _g = new Game(40, 40);
            _g.ScorePoint(1);
            Assert.AreEqual(50, _g.PlayerOneScore());

        }

        [TestMethod]
        public void At4050PlayerOneNextScoreShouldBe40()
        {
            _g = new Game(40, 50);
            _g.ScorePoint(1);
            Assert.AreEqual(40, _g.PlayerOneScore());
        }

        [TestMethod]
        public void At4050NextScoreOtherPlayersScoureShouldBe55()
        {
            _g = new Game(40, 50);
            _g.ScorePoint(2);
            Assert.AreEqual(55, _g.PlayerTwoScore());

        }

        [TestMethod]
        public void ScoreShouldShowPlayerOneScoreDashScorePlayerTwo()
        {
            _g = new Game(0, 0);
            Assert.AreEqual("Player 1 0 - 0 Player 2", _g.ToString());

        }

        #region NonTests
        #endregion

    }
}
