namespace CommonNew.ORM
{
    public class QueryCachingService
    {
        private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

        public void CacheResult<T>(string queryKey, IEnumerable<T> result)
        {
            if (!_cache.ContainsKey(queryKey))
            {
                _cache[queryKey] = result;
            }
        }

        public IEnumerable<T> GetCachedResult<T>(string queryKey)
        {
            if (_cache.ContainsKey(queryKey))
            {
                return (IEnumerable<T>)_cache[queryKey];
            }
            return [];
        }
    }
}
