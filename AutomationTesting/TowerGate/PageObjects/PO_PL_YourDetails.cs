

namespace TowerGate.PageObjects
{

    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Types;
    using static TowerGate._BaseClasses.LocalThreadDriver;


    public class PO_PL_YourDetails
    {


        private readonly ElementLocator txtEmail = new ElementLocator(Locator.Name, "p$lt$ctl06$pageplaceholder$p$lt$ctl00$UserControl$userControlElem$txtNewUserEmailAddress"),
                                        txtPhone = new ElementLocator(Locator.Name, "p$lt$ctl06$pageplaceholder$p$lt$ctl00$UserControl$userControlElem$txtOptionalTelephoneNumber");



        public void CompletePage()
        {



        }

        
    }

}
