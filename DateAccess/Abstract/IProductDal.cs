using Core.DateAccess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Abstract
{
   public interface IProductDal :IEnttiyRepositoy<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
//Code Refactoring
