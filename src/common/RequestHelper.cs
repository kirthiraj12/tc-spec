

using System;
using RestSharp;

namespace Specflow_Demo_API.APITests.Common
{
    public static class RequestHelper
    {

        public static IRestResponse Get(string endpoint)
        {
            RestClient rc = new RestClient(endpoint);
            return rc.Get(new RestRequest(""));
        }
        public static IRestResponse Get(string baseEndpoint, string endpoint)
        {
            RestClient rc = new RestClient(baseEndpoint);
            return rc.Get(new RestRequest(endpoint));
        }

        public static IRestResponse Post(string baseEndpoint, string endpoint, string value)
        {
            var rc = new RestClient(baseEndpoint);
            return Post(endpoint, value, rc);
        }
        public static IRestResponse Post(string endpoint, string value)
        {
            var rc = new RestClient(endpoint);
            return Post("", value, rc);
        }

        private static IRestResponse Post(string endpoint, string value, IRestClient rc)
        {
            var restRequest = new RestRequest(endpoint)
            {
                RequestFormat = DataFormat.Json,
                Parameters = { new Parameter("application/json", value, ParameterType.RequestBody) }
            };
            return rc.Post(restRequest);
        }

    }
}
