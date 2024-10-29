using CommonNew.Models;

namespace CommonNew.ConnectionManagement
{
    public class MsSqlConnectionBuilder : IConnectionBuilder
    {
        public string BuildConnectionString(ConnectionOptions options)
        {
            if (options.UseWindowsAuthentication)
            {
                return $"Server={options.Server};Database={options.Database};Trusted_Connection=True;";
            }
            return $"Server={options.Server};Database={options.Database};User Id={options.Username};Password={options.Password};";
        }
    }
}
