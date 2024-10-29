using CommonNew.Models;
using System.Data;
using Dapper;

namespace CommonNew.DataAccess
{
    public class DapperQueryService : IQueryService
    {
        private readonly IDbConnection _connection;

        public DapperQueryService(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<T>> ExecuteQueryAsync<T>(QueryModel query)
        {
            return await _connection.QueryAsync<T>(query.Sql, query.Parameters);
        }
    }
}
