using System;
using System.Threading;
using TechTalk.SpecFlow;
using TowerGate._BaseClasses;

namespace TowerGate.FeatureTests.AdminPanel
{
    [Binding]
    public class AdminPanelSteps : ProjectScenariosBase
    {


        public AdminPanelSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {

            driver.Url = "http://www.google.co.uk";

            Thread.Sleep(4000);

        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           
        }
    }
}
