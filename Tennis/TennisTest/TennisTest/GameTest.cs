﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisBusiness;

namespace TennisTest
{
    [TestClass]
    public class GameTest
    {

        [TestMethod]
        public void PlayerOneStartsWithZero()
        {
            Game g = new Game();
            Assert.AreEqual(0, g.PlayerOneScore);
        }

        //[TestMethod]
        //public void PlayerTwoStartsWithZero()
        //{
        // Assert.AreEqual();
        //}

        //[TestMethod]
        //public void AtZeroZeroNextScoreShouldBe15()
        //{
        // Assert.AreEqual();
        //}

        //[TestMethod]
        //public void At15ZeroNextScoreShouldBe30()
        //{
        // Assert.AreEqual();
        //}

        //[TestMethod]
        //public void At30ZeroNextScoreShouldBe40()
        //{
        // Assert.AreEqual();
        //}

        //[TestMethod]
        //public void At40ZeroNextScoreShouldBe55()
        //{
        //}

        //[TestMethod]
        //public void At4040NextScoreShouldBe50()
        //{
        // Assert.AreEqual();
        //}

        //[TestMethod]
        //public void At4050NextScoreShouldBe40()
        //{
        // Assert.AreEqual();
        //}

        //[TestMethod]
        //public void At4050NextScoreOtherPlayersScoureShouldBe40()
        //{
        // Assert.AreEqual();
        //}


    }
}