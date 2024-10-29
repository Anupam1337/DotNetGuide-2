using Dapper;

namespace CommonNew.Models
{
    public class QueryModel
    {
        public string Sql { get; set; } = string.Empty;
        public DynamicParameters Parameters { get; set; } = new();
    }
}
