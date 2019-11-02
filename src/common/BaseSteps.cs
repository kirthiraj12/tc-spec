using System;
using Newtonsoft.Json.Linq;
using RestSharp;
using Xunit.Abstractions;

 namespace Specflow_Demo_API.APITests.Common
{
    public class BaseSteps
    {
        protected readonly ITestOutputHelper OutputHelper;

        public BaseSteps(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        public IRestResponse Get(string endpoint)
        {
            return RequestHelper.Get(endpoint);
        }

        public IRestResponse Get(string baseEndpoint, string endpoint)
        {
            return RequestHelper.Get(baseEndpoint, endpoint);
        }

        public IRestResponse Post(string endpoint, string value)
        {
            return RequestHelper.Post(endpoint, value);
        }
        public IRestResponse Post(string baseEndpoint, string endpoint, string value)
        {
            return RequestHelper.Post(baseEndpoint, endpoint, value);
        }

    }
}
