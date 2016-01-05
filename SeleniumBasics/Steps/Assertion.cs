using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SeleniumBasics.Steps
{
    [Binding]
    public sealed class Assertion : Hooks
    {
        [Then(@"I can see wikipedia log")]
        public void ThenICanSeeWikipediaLog()
        {
            Driver.FindElement(By.Id("p-logo"));
        }
    }
}
