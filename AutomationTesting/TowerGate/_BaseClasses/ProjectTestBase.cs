// <copyright file="ProjectTestBase.cs" company="Objectivity Bespoke Software Specialists">
// Copyright (c) Objectivity Bespoke Software Specialists. All rights reserved.
// </copyright>
// <license>
//     The MIT License (MIT)
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
// </license>

namespace TowerGate._BaseClasses
{
    using System;

    using NUnit.Framework;
    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Logger;
    using static Runner;



    using TechTalk.SpecFlow;

    /// <summary>
    /// The base class for all tests <see href="https://github.com/ObjectivityLtd/Test.Automation/wiki/ProjectTestBase-class">More details on wiki</see>
    /// </summary>
    [Binding]
    public class ProjectTestBase : TestBase
    {
        public readonly ScenarioContext scenarioContext;
        //public readonly DriverContext driverContext = new DriverContext();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTestBase"/> class.
        /// </summary>
        /// <param name="scenarioContext"> Scenario Context </param>
        /// 
        public ProjectTestBase(ScenarioContext scenarioContext)
        {

            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");

            this.scenarioContext = scenarioContext;


        }

        /// <summary>
        /// Gets or sets logger instance for driver
        /// </summary>
        /// 
        /*
        public TestLogger LogTest
        {
            get
            {
                return this.DriverContext.LogTest;
            }

            set
            {
                this.DriverContext.LogTest = value;
            }
        }
        */

        /// <summary>
        /// Gets the browser manager
        /// </summary>
        /// 
        /*
        protected DriverContext DriverContext
        {
            get
            {
                return this.driverContext;
            }
        }
        */

        /// <summary>
        /// Before the class.
        /// </summary>
        [BeforeFeature]
        public static void BeforeClass()
        {
        }

        /// <summary>
        /// After the class.
        /// </summary>
        [AfterFeature]
        public static void AfterClass()
        {
        }

        /// <summary>
        /// Before the test.
        /// </summary>
        [Before]
        public void BeforeTest()
        {


            //this.DriverContext.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            driverContext.Value.TestTitle = this.scenarioContext.ScenarioInfo.Title;
            //this.LogTest.LogTestStarting(this.driverContext);
            //this.DriverContext.Start();
            this.scenarioContext["DriverContext"] = driverContext.Value;
       

        }

        /// <summary>
        /// After the test.
        /// </summary>
        [After]
        public void AfterTest()
        {
            try
            {
                driverContext.Value.IsTestFailed = this.scenarioContext.TestError != null || !driverContext.Value.VerifyMessages.Count.Equals(0);
                var filePaths = this.SaveTestDetailsIfTestFailed(driverContext.Value);
                this.SaveAttachmentsToTestContext(filePaths);
                var javaScriptErrors = driverContext.Value.LogJavaScriptErrors();

                //this.LogTest.LogTestEnding(driverContext.Value);
                if (this.IsVerifyFailedAndClearMessages(driverContext.Value) && this.scenarioContext.TestError == null)
                {
                    Assert.Fail();
                }

                if (javaScriptErrors)
                {
                    Assert.Fail("JavaScript errors found. See the logs for details");
                }
            }
            finally
            {
                // the context should be cleaned up no matter what
                driverContext.Value.Stop();
            }
        }

        private void SaveAttachmentsToTestContext(string[] filePaths)
        {
            if (filePaths != null)
            {
                foreach (var filePath in filePaths)
                {
                    //this.LogTest.Info("Uploading file [{0}] to test context", filePath);
                    TestContext.AddTestAttachment(filePath);
                }
            }
        }
    }
}
