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
        public void GivenIHaveAEndpoint(string endpoint)
        {
            
            RestApiHelper.SetURL(endpoint);
        }

        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfTheApi()
        {
            RestApiHelper.CreateRequest();
        }

        [Then(@"I get API response in json format")]
        public void ThenTheIGetTheAPIResponseInJsonFormat()
        {
            var Expected = "url";
            var apiResponse = RestApiHelper.GetResponse();
            Assert.That(apiResponse.Content, Is.SupersetOf(Expected), "error message");
            if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(apiResponse.Content, Is.SupersetOf(Expected), "error message");
            }

        }
        [When(@"I call get method to get user information using (.*)")]
        public void WhenICallGetMethodToGetUserInformationUsing(string n)
        {
            RestApiHelper.CreateRequest(n);
        }

        [Then(@"I will get user information")]
        public void ThenIWillGetUserInformation()
        {
            var response = RestApiHelper.GetResponse();
        }

    }

}

