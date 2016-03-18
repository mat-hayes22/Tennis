using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisBusiness;

namespace TennisTest
{
    [TestClass]
    public class GameTest
    {

        [TestMethod]
        public void AtZeroZeroNextScoreShouldBe15()
        {
            Game g = new Game("", "", 0, 0);
            g.ScorePoint(1);
            Assert.AreEqual (15, g.PlayerOneScore);

        }

        [TestMethod]
        public void At15ZeroNextScoreShouldBe30()
        {
            Game g = new Game("", "", 15, 0);
            g.ScorePoint(1);
            Assert.AreEqual(30, g.PlayerOneScore);
        }

        [TestMethod]
        public void At30ZeroNextScoreShouldBe40()
        {
            Game g = new Game("", "", 30, 0);
            g.ScorePoint(1);
            Assert.AreEqual(40, g.PlayerOneScore);

        }

        [TestMethod]
        public void At40ZeroNextScoreShouldBe55()
        {
            Game g = new Game("", "", 40, 0);
            g.ScorePoint(1);
            Assert.AreEqual(55, g.PlayerOneScore);
        }

        [TestMethod]
        public void At4040NextScoreShouldBe50()
        {
            Game g = new Game("", "", 40, 40);
            g.ScorePoint(1);
            Assert.AreEqual(50, g.PlayerOneScore);

        }


        [TestMethod]
        public void At4050PlayerOneNextScoreShouldBe40()
        {
            Game g = new Game("", "", 40, 50);
            g.ScorePoint(1);
            Assert.AreEqual(40, g.PlayerOneScore);

        }

        [TestMethod]
        public void At4050NextScoreOtherPlayersScoureShouldBe55()
        {
            Game g = new Game("", "", 40, 50);
            g.ScorePoint(2);
            Assert.AreEqual(55, g.PlayerTwoScore);

        }


    }
}
