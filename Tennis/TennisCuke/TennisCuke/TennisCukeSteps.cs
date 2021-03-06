﻿using System;
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
        public void GivenIHaveAGameAndTheScoreIs(int p0, int p1)
        {
            _g = new Game(p0, p1);
        }


        [When(@"Player (.*) scores")]
        [When(@"Player ‘(.*)’ scores")]
        public void WhenPlayerScores(int p0)
        {
            _g.ScorePoint(p0);
        }
        [Then(@"the score should show as '(.*)' (.*) - (.*) '(.*)'")]
        public void ThenTheScoreShouldShowAs(string p0, int p1, int p2, string p3)
        {
            Assert.AreEqual($"{p0} {p1} - {p2} {p3}", _g.ToString());
        }

        [Given(@"I have a game between '(.*)' and '(.*)' and current the Score is (.*) – (.*)")]
        [Given(@"I have a game between '(.*)' and '(.*)' And I have a game and the Score is (.*) – (.*)")]
        public void GivenIHaveAGameBetweenAndAndIHaveAGameAndTheScoreIs(string p0, string p1, int p2, int p3)
        {
            _g = new Game(p2, p3, p0, p1); 
        }

        [Then(@"(.*) will have (.*)")]
        public void ThenWillHave(int whichPlayer, int score)
        {
            Assert.AreEqual(score, _g.Scores[whichPlayer]);

        }



    }
}
