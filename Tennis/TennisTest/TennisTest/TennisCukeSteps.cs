using System;
using TechTalk.SpecFlow;

namespace TennisTest
{
    [Binding]
    public class TennisCukeSteps
    {
        [Given(@"I have a new game")]
        public void GivenIHaveANewGame()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"the Score is ‘(.*)‘ – ‘(.*)’")]
        public void GivenTheScoreIs(int p0, int p1)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"'(.*)' scores a point")]
        public void WhenScoresAPoint(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the score should show as '(.*)'")]
        public void ThenTheScoreShouldShowAs(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
