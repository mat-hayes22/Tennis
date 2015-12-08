using System;
using TechTalk.SpecFlow;

namespace TennisCuke
{
    [Binding]
    public class TennisCukeSteps
    {
        [Given(@"I have a game and the Score is ‘(.*)‘– ‘(.*)’")]
        public void GivenIHaveAGameAndTheScoreIs(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Player ‘(.*)’ scores")]
        public void WhenPlayerScores(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the score should show as 'Player (.*) - (.*) Player (.*)‘")]
        public void ThenTheScoreShouldShowAsPlayer_Player(string p0, int p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
