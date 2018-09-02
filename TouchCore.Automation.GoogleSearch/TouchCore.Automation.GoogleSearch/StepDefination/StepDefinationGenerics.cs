using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchCore.Automation.GoogleSearch
{
    class StepDefinationGenerics
    {

        public static IWebDriver Driver;
        static string ApplicationUrl;

        // Method Name : Launch_Application
        // Use : This Method is used to Launch the Application and Maximize the Web Page
        // Created By : Anand Kalaskar
        // Created Date : 20/08/2018 (dd/mm/yyyy)
        public void Launch_Application()
        {
            //GlobalObjects.objDriverActions.ImplicitWait();

            ApplicationUrl = ConfigurationManager.AppSettings["ApplicationURL"];
            Driver = GlobalObjects.objDriverActions.InitializeWebDriver();
            GlobalObjects.objDriverActions.NavigateToUrl(ApplicationUrl);
            GlobalObjects.objDriverActions.MaximizeWindow();
            Console.WriteLine("Application Launched Successfully");
        }

        // Method Name : Verify_WebElement_On_Screen
        // Use : This Method is used to Launch the Application and Maximize the Web Page
        // Created By : Anand Kalaskar
        // Created Date : 20/08/2018 (dd/mm/yyyy)

        public bool Verify_WebElement_On_Screen(string VerifyAttribute, By element, string ScreenName)
        {

            if ((GlobalObjects.objWebElementActions.IsDisplayed(element)) && (GlobalObjects.objWebElementActions.IsEnabled(element)))
            {
                Console.WriteLine("WebElement :: " + element.ToString() + " :: is Displayed and is Enabled on the WebPage");
                return true;
            }
            else
            {
                Console.WriteLine("WebElement :: " + element.ToString() + " :: is NOT Displayed and is NOT Enabled on the WebPage");
                return true;
            }
        }


        public string Get_PageTitle(string ScreenName)
        {
            string PageTitle = GlobalObjects.objDriverActions.GetApplicationPageTitle();
            //Console.WriteLine("Page Title is :: " + PageTitle);
            return PageTitle;
        }

    }

}

