using NLog;
using Objectivity.Test.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TowerGate._BaseClasses
{
    public class ProjectScenariosBase
    {

        protected readonly DriverContext driverContext;
        protected readonly ScenarioContext scenarioContext;
        protected readonly IWebDriver driver;
        protected  readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ProjectScenariosBase(ScenarioContext scenarioContext) 
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");

            this.scenarioContext = scenarioContext;
            this.driverContext = this.scenarioContext["DriverContext"] as DriverContext;
            this.driver = driverContext.Driver;

        }



        public String GetKeyValueFromAppConfig(String key)
        {

            return ConfigurationManager.AppSettings[key];
        }

    }
}
