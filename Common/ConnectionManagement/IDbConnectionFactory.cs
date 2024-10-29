namespace Common.ConnectionManagement
{
    public interface IDbConnectionFactory
    {
        IDatabaseModel CreateConnection();
    }
}
