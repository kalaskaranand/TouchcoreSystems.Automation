using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace TouchCore.Automation.GoogleSearch
{
    public class DriverActions
    {

        public IWebDriver Driver { get; set; }
        public string ApplicationPageTitle = null;

        // Method Name : InitializeWebDriver
        // Use : This Method is used to Initialize the WebDriver
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public IWebDriver InitializeWebDriver()
        {
            string browserName = string.Empty;
            try
            {
                browserName = ConfigurationManager.AppSettings["BrowserName"];

                switch (browserName)
                {
                    case "chrome":
                        Driver = new ChromeDriver();
                        break;
                    case "ie":
                        Driver = new InternetExplorerDriver();
                        break;
                    default:
                        throw new Exception();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return Driver;
        }

        // Method Name : InitializeWebDriver
        // Use : This Method is used to Navigat the WebDriver to the Application URL
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public void NavigateToUrl(string ApplicationUrl)
        {
            try
            {
                Driver.Navigate().GoToUrl(ApplicationUrl);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
        }


        // Method Name : InitializeWebDriver
        // Use : This Method is used to Close the Application
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public void CloseApplication()
        {
            try
            {
                Driver.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
        }

        // Method Name : InitializeWebDriver
        // Use : This Method is used to get the Application Page Title
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public string GetApplicationPageTitle()
        {
            try
            {
                ApplicationPageTitle = Driver.Title;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }
            return ApplicationPageTitle;
        }

        // Method Name : MaximizeWindow
        // Use : This Method is used to maximize the Application Page
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public void MaximizeWindow()
        {
            try
            {
                Driver.Manage().Window.Maximize();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Exception :: " + exception.ToString());
            }

        }

        // Method Name : ImplicitWait
        // Use : This Method is used perform ImplicitWait for the Driver
        // Created By : Anand Kalaskar
        // Created Date : 01/09/2018 (dd/mm/yyyy)

        public void ImplicitWait()
        {
            TimeSpan ImplicitWaitTime = TimeSpan.FromSeconds(Convert.ToInt32(ConfigurationManager.AppSettings["ImplicitWait"]));
            GlobalObjects.objDriverActions.Driver.Manage().Timeouts().ImplicitWait = ImplicitWaitTime;
        }
    }
}

