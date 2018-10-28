

namespace TowerGate.PageObjects
{

    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Extensions;
    using Objectivity.Test.Automation.Common.Types;
    using OpenQA.Selenium;
    using static Runner;

    public class PO_TowerGate_Homepage 
    {

        // All Page Object class to have this:
        //private readonly IWebDriver driver;

        //public PO_TowerGate_Homepage(IWebDriver driver) { this.driver = driver;}

        private readonly ElementLocator btnQuote = new ElementLocator(Locator.XPath, "//a[@title='Get a quote']"),
                                       btnRetQuote = new ElementLocator(Locator.XPath, "//a[@title='Retrieve quote']");


        public void BeginQuote()
        {

            driver.Value.IsElementPresent(btnQuote, BaseConfiguration.ShortTimeout);
            driver.Value.GetElement(btnQuote).Click();

        }


    }




}
