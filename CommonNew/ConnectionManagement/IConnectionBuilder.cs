using CommonNew.Models;

namespace CommonNew.ConnectionManagement
{
    public interface IConnectionBuilder
    {
        string BuildConnectionString(ConnectionOptions options);
    }
}
