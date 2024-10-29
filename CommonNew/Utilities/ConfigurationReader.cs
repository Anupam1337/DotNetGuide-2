using Microsoft.Extensions.Configuration;

namespace CommonNew.Utilities
{
    public static class ConfigurationReader
    {
        public static IConfiguration GetConfiguration(string filePath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile(filePath)
                .Build();
        }
    }
}
