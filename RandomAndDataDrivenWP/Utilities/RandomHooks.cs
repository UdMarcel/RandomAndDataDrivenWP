using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace RandomAndDataDrivenWP.Utilities
{
    [Binding]
    public class RandomHooks
    {

        public static IWebDriver driver;
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
         
    }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}