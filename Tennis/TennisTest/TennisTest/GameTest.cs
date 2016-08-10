using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisBusiness;

namespace TennisTest
{
    [TestClass]
    public class GameTest
    {
        Game _g;

        [TestMethod]
        public void PlayerOneNewGameStartsWithZero()
        {
            _g = new Game(0, 0);
            Assert.AreEqual(0,_g.Scores[1]);
        }

        [TestMethod]
        public void PlayerTwoNewGameStartsWithZero()
        {
            _g = new Game(0, 0);
            Assert.AreEqual(0, _g.Scores[2]);
        }

        [TestMethod]
        public void AtZeroZeroNextScoreShouldBe15()
        {
            _g = new Game(0, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(15,_g.Scores[1]);

        }

        [TestMethod]
        public void At15ZeroNextScoreShouldBe30()
        {
            _g = new Game(15, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(30, _g.Scores[1]);

        }

        [TestMethod]
        public void At30ZeroNextScoreShouldBe40()
        {
            _g = new Game(30, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(40, _g.Scores[1]);

        }

        [TestMethod]
        public void At40ZeroNextScoreShouldBe55()
        {
            _g = new Game(40, 0);
            _g.ScorePoint(1);
            Assert.AreEqual(55, _g.Scores[1]);

        }

        [TestMethod]
        public void At4040NextScoreShouldBe50()
        {
            _g = new Game(40, 40);
            _g.ScorePoint(1);
            Assert.AreEqual(50, _g.Scores[1]);
        }

        [TestMethod]
        public void At4050PlayerOneNextScoreShouldBe40()
        {
            _g = new Game(40, 50);
            _g.ScorePoint(1);
            Assert.AreEqual(40, _g.Scores[1]);

        }

        [TestMethod]
        public void At4050NextScoreOtherPlayersScoureShouldBe55()
        {
            _g = new Game(40, 50);
            _g.ScorePoint(2);
            Assert.AreEqual(55, _g.Scores[2]);

        }

        [TestMethod]
        public void ScoreShouldShowPlayerOneScoreDashScorePlayerTwo()
        {
            _g = new Game(0, 0);
            _g.ScorePoint(1);
            Assert.AreEqual("Player 1 15 - 0 Player 2", _g.ToString() );


        }


        #region NonTests
        #endregion

    }
}
