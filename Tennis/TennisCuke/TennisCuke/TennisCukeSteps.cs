using System;
using TechTalk.SpecFlow;
using TennisBusiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisCuke
{
    [Binding]
    public class TennisCukeSteps
    {
        Game _g;

        [Given(@"I have a game and the Score is ‘(.*)‘– ‘(.*)’")]
        public void GivenIHaveAGameAndTheScoreIs(short p0, short p1)
        {
            _g = new Game(p0, p1);
        }

        [When(@"Player ‘(.*)’ scores")]
        public void WhenPlayerScores(int p0)
        {
            _g.ScorePoint(p0);
        }

        [Then(@"the score should show as 'Player 1 (.*) - (.*) Player 2‘")]
        public void ThenTheScoreShouldShowAsPlayer_Player(string p0, int p1)
        {
            Assert.AreEqual(string.Format("Player 1 {0} - {1} Player 2", p0, p1), _g.Scores());
        }



    }
}
