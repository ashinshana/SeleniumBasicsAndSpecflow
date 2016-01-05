using TechTalk.SpecFlow;

namespace SeleniumBasics.Steps
{
    [Binding]
    public sealed class Assertion
    {
        [Then(@"I can see wikipedia log")]
        public void ThenICanSeeWikipediaLog()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
