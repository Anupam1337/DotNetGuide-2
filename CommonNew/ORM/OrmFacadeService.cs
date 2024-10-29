using CommonNew.DataAccess;
using CommonNew.Models;

namespace CommonNew.ORM
{
    public class OrmFacadeService
    {
        private readonly IQueryService _queryService;

        public OrmFacadeService(IQueryService queryService)
        {
            _queryService = queryService;
        }

        public async Task<IEnumerable<T>> GetRecordsAsync<T>(QueryModel query)
        {
            return await _queryService.ExecuteQueryAsync<T>(query);
        }
    }
}
