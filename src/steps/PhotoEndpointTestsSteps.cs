
using System.Collections.Generic;
using System.Configuration;
using TechTalk.SpecFlow;
using Specflow_Demo_API.APITests.Common;
using RestSharp;
using Xunit.Abstractions;
using Xunit;
using TestRepoSpecflow.src.common;

namespace api_acceptance_tests.Steps

{

    [Binding]

    public class PhotoEndpointSteps : BaseSteps

    {

        private IRestResponse _restResponse;

        public PhotoEndpointSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }



        [Given(@"I am requesting photo metadata")]

        public void GivenIAmRequestingPhotoMetadata()

        {
            var uri = Environments.BaseUrl;

            _restResponse = Get($"{uri}{"/"}{"photos"}");


        }



        [Then(@"the response should include ""(.*)"" as status code")]
        public void ThenTheResponseShouldIncludeAsStatusCode(string statusCode)
        {
            Assert.Equal(statusCode, _restResponse.StatusCode.ToString());
        }


    }

}