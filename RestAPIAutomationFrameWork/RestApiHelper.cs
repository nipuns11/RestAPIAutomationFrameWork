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
        public static string baseurl = "https://alexwohlbruck.github.io";

        public static RestClient SetURL(string endpoint)
        {
            var url = Path.Combine(baseurl, endpoint);
            return client =  new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept","application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
        
    }
}
