
using System.Data;
using System.Data.SqlClient;

namespace CommonNew.ConnectionManagement
{
    public class ConnectionPoolManager
    {
        private static readonly Lazy<ConnectionPoolManager> _instance = new Lazy<ConnectionPoolManager>(() => new ConnectionPoolManager());
        private readonly Dictionary<string, List<IDbConnection>> _connectionPools = new Dictionary<string, List<IDbConnection>>();
        private int _maxConnections = 10;

        private ConnectionPoolManager() { }

        public static ConnectionPoolManager Instance => _instance.Value;

        public void SetMaxConnections(int maxConnections)
        {
            _maxConnections = maxConnections;
        }

        public IDbConnection GetConnection(string connectionString)
        {
            if (!_connectionPools.ContainsKey(connectionString))
            {
                _connectionPools[connectionString] = new List<IDbConnection>();
            }

            var pool = _connectionPools[connectionString];
            if (pool.Count < _maxConnections)
            {
                var connection = new SqlConnection(connectionString);
                pool.Add(connection);
                return connection;
            }
            throw new InvalidOperationException("Connection limit reached.");
        }

        public void ReleaseConnection(string connectionString, IDbConnection connection)
        {
            if (_connectionPools.ContainsKey(connectionString))
            {
                _connectionPools[connectionString].Remove(connection);
            }
        }
    }
}
