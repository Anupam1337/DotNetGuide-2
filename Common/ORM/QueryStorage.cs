using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ORM
{
    public class QueryStorage
    {
        public string GetSelectQuery(int id)
        {
            // Return select query
            return $"SELECT * FROM table WHERE id = {id}";
        }
    }
}
