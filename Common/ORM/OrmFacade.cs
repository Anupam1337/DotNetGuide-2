using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ORM
{
    public class OrmFacade
    {
        private readonly IOrmService _ormService;

        public OrmFacade(IOrmService ormService)
        {
            _ormService = ormService;
        }

        public void SaveEntity(object entity)
        {
            _ormService.Save(entity);
        }

        public object GetEntity(int id)
        {
            return _ormService.Get(id);
        }
    }
}
