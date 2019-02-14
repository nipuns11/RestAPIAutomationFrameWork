using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace RestAPIAutomationFrameWork.Steps
{
    [Binding]
    public sealed class ApiApplication
    {
        [Given(@"I have a endpoint (.*)")]
        public void GivenIHaveAEndpointEndpoint(string endpoint)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a base url (.*)")]
        public void GivenIHaveABaseUrl(string baseURL)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I call get method of the api")]
        public void WhenICallGetMethodOfTheApi()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the I get the API response in json format")]
        public void ThenTheIGetTheAPIResponseInJsonFormat()
        {
            ScenarioContext.Current.Pending();
            // checkc 
        }

    }
}
