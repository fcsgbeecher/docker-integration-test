using System;
using System.Configuration;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DockerIntegration.Integration.Tests
{
    [TestClass]
    public class ValuesControllerTests
    {
        public string RootUrl{get; set;}

        [TestInitialize]
        public void Initialize()
        {
            RootUrl = ConfigurationManager.AppSettings["url"];
        }

        [TestMethod]
        public void CanGetValues()
        {
            var result = ExecuteRequest("Values");
            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        private string ExecuteRequest(string endpoint)
        {
            using(var client = new WebClient())
            {
                var url = RootUrl.TrimEnd('/') + "/api/" + endpoint;
                return client.DownloadString(url);
            }
           
        }
    }
}
