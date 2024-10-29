namespace Common.ConnectionManagement
{
    public class MsSqlConnectionStringBuilder : IDbConnectionStringBuilder
    {
        public string BuildConnectionString()
        {
            // MSSQL connection string
            return "MSSQL-Connection-String";
        }
    }
}
