using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace TouchCore.Automation.GoogleSearch
{
    class WebElementActions
    {

        // Method Name : FindElement
        // Use : This Method is used to Find the Element by using its locator
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public IWebElement FindElement(By locator)
        {
            IWebElement element = null;
            try
            {
                element = GlobalObjects.objDriverActions.Driver.FindElement(locator);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return element;
        }
        // Method Name : IsDisplayed
        // Use : This Method is used to check the Displayed condition of WebElement
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)
        public bool IsDisplayed(By locator)
        {
            bool flag = false;
            IWebElement element = null;
            try
            {
                element = FindElement(locator);
                flag = element.Displayed;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return flag;
        }

        // Method Name : IsEnabled
        // Use : This Method is used to check the Enabled condition of WebElement
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public bool IsEnabled(By locator)
        {
            bool flag = false;
            IWebElement element = null;
            try
            {
                element = FindElement(locator);
                flag = element.Enabled;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return flag;
        }

        // Method Name : IsEnabled
        // Use : This Method is used to perform the Click Action on the WebElement
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public void ClickAction(By locator)
        {
            IWebElement element;
            try
            {
                element = FindElement(locator);
                element.Click();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
        }

        // Method Name : SendKeys
        // Use : This Method is used to check perform SendKey operation on the WebElement
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public void SendKeys(By locator, string value)
        {
            IWebElement element;
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    element = FindElement(locator);
                    element.SendKeys(value);
                    element.SendKeys(Keys.Tab);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
        }

        // Method Name : FindElements
        // Use : This Method is used to get the collection of desired WebElements
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            ReadOnlyCollection<IWebElement> elements = null;
            try
            {
                elements = GlobalObjects.objDriverActions.Driver.FindElements(locator);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return elements;
        }

    }
}
