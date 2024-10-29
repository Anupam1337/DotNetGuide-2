namespace Common.ConnectionManagement
{
    public class PostgreSqlConnectionStringBuilder : IDbConnectionStringBuilder
    {
        public string BuildConnectionString()
        {
            // PostgreSQL connection string
            return "PostgreSQL-Connection-String";
        }
    }
}
