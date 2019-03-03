using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIAutomationFrameWork
{
    public static class RestApiHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseurl = "https://httpbin.org";

        public static RestClient SetURL(string endpoint)
        {
            var url = baseurl + endpoint;
            return client =  new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept","application/json");
            return restRequest;
        }
        //overloading method
        public static RestRequest CreateRequest(string n)
        {
            var resource = n;    
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
        
    }
}
