using NUnit.Framework;
using Objectivity.Test.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

using Objectivity.Test.Automation.Common.Extensions;




    [SetUpFixture]
    public class Runner
    {

        private DriverContext driverContextInstance = new DriverContext();
        //private IWebDriver driverInstance;

        public static ThreadLocal<DriverContext> driverContext = new ThreadLocal<DriverContext>();
        public static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public Runner()
        {


            this.driverContextInstance.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //this.driverContext.TestTitle = this.scenarioContext.ScenarioInfo.Title;
            this.driverContextInstance.LogTest.LogTestStarting(this.driverContextInstance);
            this.driverContextInstance.Start();
            //this.scenarioContext["DriverContext"] = this.driverContext;

            driverContext.Value = this.driverContextInstance;
            driver.Value = this.driverContextInstance.Driver;


        }

    }


