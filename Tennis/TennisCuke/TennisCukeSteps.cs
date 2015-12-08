using System;
using TechTalk.SpecFlow;
using TennisBusiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TennisCuke
{
    [Binding]
    public class TennisCukeSteps
    {
        Game g;

        [Given(@"I have a tennis game and the score is '(.*)' - '(.*)'")]
        public void GivenIHaveATennisGameAndTheScoreIs_(int p0, int p1)
        {
            g = new Game(p0, p1);
        }

        [When(@"a point is scored by player '(.*)'")]
        public void WhenAPointIsScoredByPlayer(int p0)
        {
            g.ScorePoint(p0 - 1);
        }

        [Then(@"the score should be '(.*)'")]
        public void ThenTheScoreShouldBe(string p0)
        {
            Assert.AreEqual(p0, g.ToString());
        }


    }
}
