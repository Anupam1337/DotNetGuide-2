using CommonNew.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CommonNew.ORM
{
    public class OrmConnectionAdapter
    {
        public IQueryService AdaptToDapper(IDbConnection connection)
        {
            return new DapperQueryService(connection);
        }

        public IQueryService AdaptToEntityFramework(DbContext context)
        {
            return new EntityFrameworkQueryService(context);
        }
    }
}
