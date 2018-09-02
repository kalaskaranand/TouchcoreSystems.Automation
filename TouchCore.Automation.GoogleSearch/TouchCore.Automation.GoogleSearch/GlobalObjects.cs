using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchCore.Automation.GoogleSearch
{
    class GlobalObjects
    {

        internal static DriverActions objDriverActions;
        internal static StepDefinationGenerics objStepDefinationGenerics;
        internal static GoogleHomePage objGoogleHomePage;
        internal static GoogleSearchResultPage objGoogleSearchResultPage;
        internal static WebElementActions objWebElementActions;
        internal static NumberUtils objNumberUtils;
        internal static StringUtils objStringUtils;

        public static void Initialize()
        {
            objDriverActions = new DriverActions();
            objStepDefinationGenerics = new StepDefinationGenerics();
            objGoogleHomePage = new GoogleHomePage();
            objGoogleSearchResultPage = new GoogleSearchResultPage();
            objWebElementActions = new WebElementActions();
            objNumberUtils = new NumberUtils();
            objStringUtils = new StringUtils();
        }

    }
}
