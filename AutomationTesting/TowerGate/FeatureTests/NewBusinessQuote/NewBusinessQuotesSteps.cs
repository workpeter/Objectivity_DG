

using NUnit.Framework;
using Objectivity.Test.Automation.Common;
using Objectivity.Test.Automation.Common.Extensions;

using System;
using System.Diagnostics;
using System.Threading;
using TechTalk.SpecFlow;
using TowerGate._BaseClasses;
using TowerGate.PageObjects;
using static Runner;

namespace TowerGate.FeatureTests.NewBusinessQuote
{
    [Binding]
    public class NewBusinessQuotesSteps : ThreadLocalDriver
    {

        public NewBusinessQuotesSteps(ScenarioContext scenarioContext) : base (scenarioContext){}

        [Given(@"the user has began the (.+) UI journey for new quote")]
        public void GivenTheUserHasBeganUIJourneyForNewQuote(String product)
        {

            switch (product)
            {
                case "PrimeLet":
                    driver.Value.Url = GetKeyValueFromAppConfig("homepage_PrimeLet");
                    break;
                case "Specialists":
                    driver.Value.Url = GetKeyValueFromAppConfig("homepage_Specialists");
                    break;
                case "BedRated":
                    driver.Value.Url = GetKeyValueFromAppConfig("homepage_BedRated");
                    break;
                case "Unoccupied":
                    driver.Value.Url = GetKeyValueFromAppConfig("homepage_Unoccupied");
                    break;
                case "HolidayHomes":
                    driver.Value.Url = GetKeyValueFromAppConfig("homepage_HolidayHomes");
                    break;
                default:
                    Assert.Fail("Scenario failed: The Product entered was not recognized. Unable to determine which URL to goto");
                    break;
            }

            new PO_TowerGate_Homepage().BeginQuote();


       
        }

        [When(@"the quote process is repeated multiple times in accordance to the (.+) file")]
        public void WhenTheQuoteProcessIsRepeatedMultipleTimesInAccordanceToTheVariations_CsvFile(String input_csv_file)
        {



           // txtEmail


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

            Thread.Sleep(5000);

            //An assertion can be used here. The code can read the results output csv file and fail this step if detects any failed runs. 
        }




        [Given(@"just a random given example")]
        public void GivenJustARandomGivenExample()
        {

            driver.Value.Url = "http://www.microsoft.com";
            Thread.Sleep(5000);

            //ScenarioContext.Current.Pending();
        }

        [When(@"just a random when example")]
        public void WhenJustARandomWhenExample()
        {
           //ScenarioContext.Current.Pending();
        }

        [Then(@"just a random then example")]
        public void ThenJustARandomThenExample()
        {
           //ScenarioContext.Current.Pending();
        }




    }
}
