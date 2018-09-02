using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchCore.Automation.GoogleSearch
{
    class GoogleHomePage
    {
        private By txtGoogleSearch = By.Name("q");
        private By btnGoogleSearch = By.Name("btnK");

        //WebElementActions WebElementActions = new WebElementActions();

        public void Enter_Text_In_WebElement(string Value, string WebElement)
        {
            if (WebElement == "txtGoogleSearch")
            {
                GlobalObjects.objWebElementActions.SendKeys(txtGoogleSearch, Value);
            }
        }

        public void Click_Element(string WebElement, string ScreenName)
        {
            if (WebElement == "btnGoogleSearch")
            {
                GlobalObjects.objWebElementActions.ClickAction(btnGoogleSearch);
            }
        }



    }
}
