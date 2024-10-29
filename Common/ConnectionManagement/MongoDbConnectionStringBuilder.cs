namespace Common.ConnectionManagement
{
    public class MongoDbConnectionStringBuilder : IDbConnectionStringBuilder
    {
        public string BuildConnectionString()
        {
            // MongoDB connection string
            return "MongoDB-Connection-String";
        }
    }
}
