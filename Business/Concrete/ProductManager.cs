using Business.Abstract;
using DateAccess.Abstract;
using DateAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetALL()
        {
            //iş kodları
            return _productDal.GetAll();
        }
    }

}