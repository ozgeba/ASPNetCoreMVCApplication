using RestSharp;
using System;

namespace Infrastructure
{
    public class ApiCall
    {
        public static string GetValueById(int i)
        {
            var client = new RestClient(string.Format("http://localhost:54802/api/values/{0}", i));
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
