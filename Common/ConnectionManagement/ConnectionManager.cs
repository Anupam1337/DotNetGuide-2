namespace Common.ConnectionManagement
{
    public class ConnectionManager : IDbConnectionFactory
    {
        public IDatabaseModel CreateConnection()
        {
            // Connection management logic
            return new DatabaseModel();
        }
    }
}
