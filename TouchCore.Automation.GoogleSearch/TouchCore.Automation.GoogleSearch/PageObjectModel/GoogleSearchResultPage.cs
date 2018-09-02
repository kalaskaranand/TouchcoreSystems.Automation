using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchCore.Automation.GoogleSearch
{
    class GoogleSearchResultPage
    {
        //public By lnkGoogleSearch = By.XPath("//a[contains(@href,'Touchcore Systems')]");
        public By lnkGoogleSearch = By.XPath("//div[@class='g']//div/h3[@class='r']");
                
        WebElementActions WebElementActions = new WebElementActions();

        public void Print_nth_Link_Name(int ElementNumber, string WebElement)
        {
            if (WebElement == "lnkGoogleSearch")
            {
                ReadOnlyCollection<IWebElement> Link_Element_Collection = WebElementActions.FindElements(lnkGoogleSearch);
                string LinkName = Link_Element_Collection.ElementAt(ElementNumber - 1).Text;
                Console.WriteLine("Fifth Element on the Screen is :: " + LinkName);
            }
        }
        public void Total_Number_Search_Links(string WebElement)
        {
            if (WebElement == "lnkGoogleSearch")
            {
                ReadOnlyCollection<IWebElement> Link_Element_Collection = WebElementActions.FindElements(lnkGoogleSearch);
                int LinksCount = Link_Element_Collection.Count;
                Console.WriteLine("Total Number of Search Links :: " + LinksCount);
            }
        }
    }
}
