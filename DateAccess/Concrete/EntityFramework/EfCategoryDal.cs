using Core.DataAccess.EntittyFramework;
using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }

}
       
