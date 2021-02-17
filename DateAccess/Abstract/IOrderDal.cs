using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.DateAccess;

namespace DateAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {

    }
}
