
using System.Collections.Generic;
using System.Configuration;
using TechTalk.SpecFlow;
using Specflow_Demo_API.APITests.Common;
using RestSharp;
using Xunit.Abstractions;
using Xunit;
using TestRepoSpecflow.src.common;
using Newtonsoft.Json.Linq;

namespace api_acceptance_tests.Steps

{

    [Binding]

    public class UserEndpointSteps : BaseSteps

    {
        private IRestResponse _restResponse;

        public UserEndpointSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

 
        [Given(@"I am requesting user metadata endpoint")]
        public void GivenIAmRequestingUserMetadataEndpoint()
        {
            var uri = Environments.BaseUrl;

            _restResponse = Get($"{uri}{"/"}{"users"}");
        }


        [Then(@"the response should have ""(.*)"" as status code")]
        public void ThenTheResponseShouldHaveAsStatusCode(string statusCode)
        {
            Assert.Equal(statusCode, _restResponse.StatusCode.ToString());
        }



        [Then(@"each user must include field ""(.*)""")]
        public void ThenEachUserMustIncludeField(string fieldName)
        {
     //       Assert.Equal(fieldName, _restResponse.Content.Contains(fieldName).ToString());

            JObject o = JObject.Parse(_restResponse.ToString());

            JToken id1 = o.SelectToken("$.id");

            Assert.Equal(fieldName, id1);

        }


    }

}