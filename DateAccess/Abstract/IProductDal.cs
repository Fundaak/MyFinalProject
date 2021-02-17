using Core.DateAccess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Abstract
{
   public interface IProductDal :IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
//Code Refactoring
