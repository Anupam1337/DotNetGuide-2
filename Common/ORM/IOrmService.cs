using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ORM
{
    public interface IOrmService
    {
        void Save(object entity);
        object Get(int id);
    }
}
