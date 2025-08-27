using Microsoft.Extensions.Configuration;

namespace TestAutomation.RestApi.Config
{
    public static class ConfigManager
    {
        private static IConfigurationRoot _config;

        static ConfigManager()
        {

            var baseDirectory = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());
            _config = baseDirectory.AddJsonFile("Config/appsettings.json")
                   .Build();
        }

        public static string GetBaseUrl() => _config["BaseUrl"];

    }
}
