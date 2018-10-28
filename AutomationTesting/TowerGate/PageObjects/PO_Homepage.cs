

namespace TowerGate.PageObjects
{
    using NUnit.Framework;
    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Types;

    [TestFixture]
    public static class PO_Homepage 
    {


        public static readonly ElementLocator btnQuote = new ElementLocator(Locator.XPath, "//a[@title='Get a quote']"),
                                              btn_retQuote = new ElementLocator(Locator.XPath, "//a[@title='Retrieve quote']");


        [Test]
        public static void AaADS()
        {

            Assert.IsTrue(true);


        }

    }

  
}
