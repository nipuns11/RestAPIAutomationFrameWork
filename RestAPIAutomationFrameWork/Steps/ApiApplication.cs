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

       
        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfTheApi()
        {
            RestApiHelper.CreateRequest();
        }

        [Then(@"I get API response in json format")]
        public void ThenTheIGetTheAPIResponseInJsonFormat()
        {
            var Expected = "abilities";
            var apiResponse = RestApiHelper.GetResponse();
            //Assert.That(apiResponse.Content, Is.EqualTo(Expected), "error message");
            if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(apiResponse.Content,Is.EqualTo(Expected),"error message");
            }


        }

    }
}
