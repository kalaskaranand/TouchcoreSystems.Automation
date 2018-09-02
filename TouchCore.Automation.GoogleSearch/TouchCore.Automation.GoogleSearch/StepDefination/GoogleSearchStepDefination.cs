using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Configuration;

namespace TouchCore.Automation.GoogleSearch
{
    [Binding]
    public class GoogleSearchStepDefination
    {
        [Given(@"I launch the Application")]
        public void I_Launch_The_Application()
        {
            GlobalObjects.Initialize();
            GlobalObjects.objStepDefinationGenerics.Launch_Application();

            // Dynamicallay generated Test Data of String Type of Specified Length

            Console.WriteLine("Random String of 3 char is :: " + StringUtils.Get_Random_String(3));
            Console.WriteLine("Random String of 4 char is :: " + StringUtils.Get_Random_String(4));
            Console.WriteLine("Random String of 5 char is :: " + StringUtils.Get_Random_String(5));
            Console.WriteLine("Random String of 6 char is :: " + StringUtils.Get_Random_String(6));
            Console.WriteLine("Random String of 7 char is :: " + StringUtils.Get_Random_String(7));

            // Dynamicallay generated Test Data of Alphanumeric Type of Specified Length

            Console.WriteLine("Random ALPHANUMERIC String of 7 char is :: " + StringUtils.Get_Random_AlphaNumeric_String(7));
            Console.WriteLine("Random ALPHANUMERIC String of 8 char is :: " + StringUtils.Get_Random_AlphaNumeric_String(8));
            Console.WriteLine("Random ALPHANUMERIC String of 9 char is :: " + StringUtils.Get_Random_AlphaNumeric_String(9));
            Console.WriteLine("Random ALPHANUMERIC String of 10 char is :: " + StringUtils.Get_Random_AlphaNumeric_String(10));

            Console.WriteLine("Current Step is :: "+ ScenarioContext.Current.StepContext.StepInfo.Text);
                
        }

        [Given(@"I verify ""(.*)"" of ""(.*)"" on ""(.*)"" Screen")]
        public void I_Verify_WebElement_On_Screen(string VerifyAttribute, By WebElement, string ScreenName)
        {
            bool flag = GlobalObjects.objStepDefinationGenerics.Verify_WebElement_On_Screen(VerifyAttribute, WebElement, ScreenName);
        }

        [Then(@"I Validate PageTitle of ""(.*)"" Screen")]
        public void Validate_Page_Title(string ScreenName)
        {
            string PageTitle = GlobalObjects.objStepDefinationGenerics.Get_PageTitle(ScreenName);
            Console.WriteLine("Page Title is :: " + PageTitle);

            Console.WriteLine("Current Step is :: " + ScenarioContext.Current.StepContext.StepInfo.Text);
        }

        [Given(@"I Enter ""(.*)"" details in ""(.*)"" on ""(.*)"" screen")]
        public void I_Enter_Details_In_On_Screen(string Value, string WebElementName, string ScreenName)
        {
            GlobalObjects.objGoogleHomePage.Enter_Text_In_WebElement(Value, WebElementName);
            Console.WriteLine("SearchKey is entered successfully.");

            Console.WriteLine("Current Step is :: " + ScenarioContext.Current.StepContext.StepInfo.Text);
        }

        [When(@"I Click ""(.*)"" on ""(.*)"" Screen")]
        public void I_Click_On_Screen(string WebElement, string ScreenName)
        {
            GlobalObjects.objGoogleHomePage.Click_Element(WebElement, ScreenName);
            Console.WriteLine("Search Button is clicked successfully.");
            Console.WriteLine("Current Step is :: " + ScenarioContext.Current.StepContext.StepInfo.Text);
        }

        [Then(@"I Close the Application")]
        public void ThenICloseTheApplication()
        {
            GlobalObjects.objDriverActions.Driver.Close();
            Console.WriteLine("Current Step is :: " + ScenarioContext.Current.StepContext.StepInfo.Text);
        }

        [Then(@"I Verify the ""(.*)""th link element of the type ""(.*)"" Screen")]
        public void Verify_The_LinkElement_On_Screen(int ElementNumber, string WebElement)
        {
            GlobalObjects.objGoogleSearchResultPage.Total_Number_Search_Links(WebElement);
            GlobalObjects.objGoogleSearchResultPage.Print_nth_Link_Name(ElementNumber, WebElement);
            Console.WriteLine("Current Step is :: " + ScenarioContext.Current.StepContext.StepInfo.Text);
        }

    }
}


