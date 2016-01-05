using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SeleniumBasics
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver Driver = new FirefoxDriver();

        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    Driver = new FirefoxDriver();
        //}

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
