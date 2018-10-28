

namespace TowerGate.PageObjects
{

    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Extensions;
    using Objectivity.Test.Automation.Common.Types;
    using static TowerGate._BaseClasses.LocalThreadDriver;

    public class PO_PL_Homepage 
    {

        private readonly ElementLocator btnQuote = new ElementLocator(Locator.XPath, "//a[@title='Get a quote']"),
                                       btnRetQuote = new ElementLocator(Locator.XPath, "//a[@title='Retrieve quote']");


        public void BeginQuote()
        {

            driver.Value.IsElementPresent(btnQuote, BaseConfiguration.ShortTimeout);
            driver.Value.GetElement(btnQuote).Click();

        }


    }




}
