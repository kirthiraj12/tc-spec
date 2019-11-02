using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using TechTalk.SpecFlow;
using TestRepoSpecflow.src.common;


namespace TestRepoSpecflow
{
    [Binding]
    public class EnvironmentSetup
    {

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json").Build();

            Environments.BaseUrl = config["host"];
        }
    }
}
