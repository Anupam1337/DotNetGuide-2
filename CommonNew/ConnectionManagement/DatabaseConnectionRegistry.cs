namespace CommonNew.ConnectionManagement
{
    public class DatabaseConnectionRegistry
    {
        private readonly Dictionary<string, IConnectionBuilder> _registry = new Dictionary<string, IConnectionBuilder>();

        public void RegisterDatabaseType(string dbType, IConnectionBuilder builder)
        {
            if (!_registry.ContainsKey(dbType))
            {
                _registry.Add(dbType, builder);
            }
        }

        public IConnectionBuilder GetConnectionBuilder(string dbType)
        {
            if (_registry.ContainsKey(dbType))
            {
                return _registry[dbType];
            }
            throw new InvalidOperationException($"Connection builder for {dbType} not found.");
        }
    }
}
