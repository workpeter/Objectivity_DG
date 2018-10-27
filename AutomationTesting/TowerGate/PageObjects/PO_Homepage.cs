

namespace TowerGate.PageObjects
{

    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Types;

    public static class PO_Homepage 
    {


        public static readonly ElementLocator btn_getQuote = new ElementLocator(Locator.XPath, "//a[@title='Get a quote']"),
                                              btn_retQuote = new ElementLocator(Locator.XPath, "//a[@title='Retrieve quote']");



    }
}
