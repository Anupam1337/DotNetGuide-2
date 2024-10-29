namespace Common.DataAccess
{
    public class QueryExecutorDecorator : IQueryExecutor
    {
        private readonly IQueryExecutor _executor;

        public QueryExecutorDecorator(IQueryExecutor executor)
        {
            _executor = executor;
        }

        public void ExecuteQuery(string query)
        {
            // Additional logic before execution
            _executor.ExecuteQuery(query);
            // Additional logic after execution
        }
    }
}
