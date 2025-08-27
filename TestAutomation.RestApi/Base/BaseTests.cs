using NUnit.Framework;
using TestAutomation.RestApi.Config;
using TestAutomation.RestApi.Core;

namespace TestAutomation.RestApi.Base
{
    public class BaseTests
    {
        protected ApiClient ApiClient { get; private set; }

        [OneTimeSetUp]
        public void GlobalSetup()
        {

            var baseUrl = ConfigManager.GetBaseUrl();
            ApiClient = new ApiClient(baseUrl);
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {            
            ApiClient = null;
        }
    }
}
