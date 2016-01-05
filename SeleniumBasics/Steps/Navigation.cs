using TechTalk.SpecFlow;
using OpenQA.Selenium;


namespace SeleniumBasics.Steps
{
    [Binding]
    public class Navigation : Hooks
    {
        [Given(@"I am on the wikipedia page")]
        public void GivenIAmOnTheWikipediaPage()
        {
            Driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            Driver.FindElement(By.Id("p-logo"));
        }
    }
}
