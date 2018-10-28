

using CsvHelper;
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;
using TowerGate._BaseClasses;
using TowerGate.DataDriven.LandLord;
using TowerGate.PageObjects;
using static TowerGate._BaseClasses.LocalThreadDriver;


using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CsvHelper;


namespace TowerGate.FeatureTests.NewBusinessQuote
{
    [Binding]
    public class NewBusinessQuotesSteps 
    {

        //This constructor required before any feature steps class 
        //to set the Driver Context in relation to the Scenario Context
        public NewBusinessQuotesSteps(ScenarioContext scenarioContext) {

            new LocalThreadDriver().SetDriverContext(scenarioContext);

        }

        [Given(@"the user has began the (.+) UI journey for new quote")]
        public void GivenTheUserHasBeganUIJourneyForNewQuote(String product)
        {

            //Goto an appropiate homepage depending on the Product
            switch (product)
            {


                case "LandLord":
                    driver.Value.Url = ConfigurationManager.AppSettings["homepage_LandLords"];
                    break;
                case "PrimeLet":
                    driver.Value.Url = ConfigurationManager.AppSettings["homepage_PrimeLet"]; 
                    break;
                case "Specialists":
                    driver.Value.Url = ConfigurationManager.AppSettings["homepage_Specialists"];
                    break;
                case "BedRated":
                    driver.Value.Url = ConfigurationManager.AppSettings["homepage_BedRated"];
                    break;
                case "Unoccupied":
                    driver.Value.Url = ConfigurationManager.AppSettings["homepage_Unoccupied"];
                    break;
                case "HolidayHomes":
                    driver.Value.Url = ConfigurationManager.AppSettings["homepage_HolidayHomes"];
                    break;
                default:
                    Assert.Fail("Scenario failed: The Product entered was not recognized. Unable to determine which URL to goto");
                    break;
            }

            new PO_PL_Homepage().BeginQuote();

       
        }

        [When(@"the quote process is repeated multiple times in accordance to the (.+) file")]
        public void WhenTheQuoteProcessIsRepeatedMultipleTimesInAccordanceToTheVariations_CsvFile(String input_csv_file)
        {


            String path = "C:\\Users\\workpeter\\source\\repos\\Objectivity_DG\\AutomationTesting\\TowerGate\\DataDriven\\LandLord\\users.csv";

            using (var sr = new StreamReader(path))
            {
                var reader = new CsvReader(sr);

                //CSVReader will now read the whole file into an enumerable
                IEnumerable<UsersContentModel> records = reader.GetRecords<UsersContentModel>();

                //First X records in CSV file will be printed to the Output Window
                foreach (UsersContentModel record in records.Take(50))
                {
                    Debug.WriteLine("{0}, {1}, {2}", record.user, record.password, record.message);
                }
            }



            //var path = "C:\\Users\\workpeter\\source\\repos\\Objectivity_DG\\AutomationTesting\\TowerGate\\DataDriven\\TestDataCsv.csv";
            //IEnumerable<TestCaseData> dd = DataDrivenHelper.ReadDataDriveFileCsv(path, new[] { "user", "password" }, "credentialCsv");

            // IEnumerable<int> myInts = ReturnSomething<int>();

            //dd.GetEnumerator



            //foreach (TestCaseData data in TestData.CredentialsCSV())
            //{





            //Debug.WriteLine("GGGGGGGGGGGGGGGGGGGGGGG" + data.Arguments[0].ToString());





            // }









            new PO_PL_YourDetails().CompletePage();


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
