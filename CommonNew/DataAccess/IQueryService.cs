using CommonNew.Models;

namespace CommonNew.DataAccess
{
    public interface IQueryService
    {
        Task<IEnumerable<T>> ExecuteQueryAsync<T>(QueryModel query);
    }
}
