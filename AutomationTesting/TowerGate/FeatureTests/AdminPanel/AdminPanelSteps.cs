using System;
using System.Threading;
using TechTalk.SpecFlow;
using TowerGate._BaseClasses;
using static TowerGate._BaseClasses.LocalThreadDriver;

namespace TowerGate.FeatureTests.AdminPanel
{
    [Binding]
    public class AdminPanelSteps 
    {

        //This constructor required before any feature steps class 
        //to set the Driver Context in relation to the Scenario Context
        public AdminPanelSteps(ScenarioContext scenarioContext)
        {
            new LocalThreadDriver().SetDriverContext(scenarioContext);
        }


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {

            driver.Value.Url = "http://www.google.co.uk";

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
