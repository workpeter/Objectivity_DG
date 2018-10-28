using NLog;
using NUnit.Framework;
using Objectivity.Test.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static Runner;

/*
Note: 

ScenarioContext.Current.Pending(); //Set a scenario step to pending

*/


namespace TowerGate._BaseClasses
{
    public class ThreadLocalDriver
    {

        ///protected readonly DriverContext driverContext;
        protected readonly ScenarioContext scenarioContext;
       // protected readonly IWebDriver driver;
        //protected readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ThreadLocalDriver(ScenarioContext scenarioContext) 
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");

            this.scenarioContext = scenarioContext;
            driverContext.Value = this.scenarioContext["DriverContext"] as DriverContext;
            driver.Value = driverContext.Value.Driver; //maybe not needed

        }

        public String GetKeyValueFromAppConfig(String key)
        {

            return ConfigurationManager.AppSettings[key];
        }


        public void Output (String message)
        {

            TestContext.Out.WriteLine(message);
            System.Diagnostics.Trace.WriteLine(message);

        }

    }
}
