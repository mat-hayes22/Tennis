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


        [Given(@"I have a game with a score of '(.*)' - '(.*)'")]
        public void GivenIHaveAGameWithAScoreOf_(int p0, int p1)
        {
            g = new Game(p0, p1);
        }

        [When(@"Player '(.*)' scores a point")]
        public void WhenPlayerScoresAPoint(int p0)
        {
            g.Score(p0);
        }

        [Then(@"the score should show as Player 1 '(.*)' - '(.*)' Player 2")]
        public void ThenTheScoreShouldShowAsPlayer_Player(int p0, int p1)
        {
            Assert.AreEqual(string.Format("Player 1 {0} - {1} Player 2", p0, p1), g.Scores());
        }

        [Given(@"I have a game between '(.*)' and '(.*)' and the score is '(.*)' - '(.*)'")]
        public void GivenIHaveAGameBetweenAndAndTheScoreIs_(string p0, string p1, int p2, int p3)
        {
            g = new Game(p2, p3, p0, p1);
        }

        [Then(@"the score should show as '(.*)' '(.*)' - '(.*)' '(.*)'")]
        public void ThenTheScoreShouldShowAs_(string p0, int p1, int p2, string p3)
        {
            Assert.AreEqual(string.Format("{0} {1} - {2} {3}", p0, p1, p2, p3), g.Scores());
        }



    }
}




