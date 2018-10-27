

using Objectivity.Test.Automation.Common;
using Objectivity.Test.Automation.Common.Extensions;

using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TowerGate._BaseClasses;
using TowerGate.PageObjects;

namespace TowerGate.FeatureTests.NewBusinessQuote
{
    [Binding]
    public class NewBusinessQuotesSteps : ProjectScenariosBase
    {

        public NewBusinessQuotesSteps(ScenarioContext scenarioContext) : base (scenarioContext){}

        [Given(@"the user has began the (.+) UI journey for new quote")]
        public void GivenTheUserHasBeganThePrimeLetUIJourneyForNewQuote(String product)
        {

            driver.NavigateTo(new Uri(BaseConfiguration.GetUrlValue));
            driver.IsElementPresent(PO_Homepage.btn_getQuote, BaseConfiguration.ShortTimeout);
            driver.GetElement(PO_Homepage.btn_getQuote).Click();

            //Selenium code here, passing product variable into existing utils framework
            //To limit product execution; modify 'examples' in the feature file. 
        }

        [When(@"the quote process is repeated multiple times in accordance to the (.+) file")]
        public void WhenTheQuoteProcessIsRepeatedMultipleTimesInAccordanceToTheVariations_CsvFile(String input_csv_file)
        {

            //the code to fully execute the new business quote process will go here. Expecting this to be a long running step
            //The variations file location is inserted by specflow via 'examples' table.  
        }

        [Then(@"the results are outputted to (.+)")]
        public void ThenTheResultsAreOutputtedToResults_CsvFile(String output_csv_file)
        {
           //this main purpose of this step is to simply link to the output csv file to gain access to low level test results. 
        }

        [Then(@"the results show that every quote expectation passed")]
        public void ThenTheResultsShowThatEveryQuoteExpectationPassed()
        {
            //An assertion can be used here. The code can read the results output csv file and fail this step if detects any failed runs. 
        }
    }
}
