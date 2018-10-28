

namespace TowerGate.PageObjects
{
    using NUnit.Framework;
    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Types;
    using Objectivity.Test.Automation.Tests.PageObjects;

    public class PO_PL_YourDetails : ProjectPageBase
    {

        public PO_PL_YourDetails(DriverContext driverContext) : base(driverContext) { }

        public  readonly ElementLocator txtEmail = new ElementLocator(Locator.Name, "p$lt$ctl06$pageplaceholder$p$lt$ctl00$UserControl$userControlElem$txtNewUserEmailAddress"),
                                        txtPhone = new ElementLocator(Locator.Name, "p$lt$ctl06$pageplaceholder$p$lt$ctl00$UserControl$userControlElem$txtOptionalTelephoneNumber");




        
    }

}
