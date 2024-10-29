namespace Common.ConnectionManagement
{
    public class MySqlConnectionStringBuilder : IDbConnectionStringBuilder
    {
        public string BuildConnectionString()
        {
            // MySQL connection string
            return "MySQL-Connection-String";
        }
    }
}
