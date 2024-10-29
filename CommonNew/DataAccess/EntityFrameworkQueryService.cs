using CommonNew.Models;
using Microsoft.EntityFrameworkCore;

namespace CommonNew.DataAccess
{
    public class EntityFrameworkQueryService : IQueryService
    {
        private readonly DbContext _context;

        public EntityFrameworkQueryService(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> ExecuteQueryAsync<T>(QueryModel query)
        {
            return await _context.Set<T>().FromSqlRaw(query.Sql, query.Parameters).ToListAsync();
        }
    }
}
