using NUnit.Framework;
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
            RestApiHelper.SetURL(endpoint);
        }

        //[Given(@"I have a base url (.*)")]
        //public void GivenIHaveABaseUrl(string baseURL)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"I call get method of the api")]
        public void WhenICallGetMethodOfTheApi()
        {
            RestApiHelper.CreateRequest();
        }

        [Then(@"the I get the API response in json format")]
        public void ThenTheIGetTheAPIResponseInJsonFormat()
        {
            var Expected = "hello";
            var apiResponse = RestApiHelper.GetResponse();
            if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(apiResponse.Content,Is.EqualTo(Expected),"error message");
            }
        }

    }
}
