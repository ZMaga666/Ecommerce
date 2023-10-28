using Ecommerce.Core.DataAccess.EntityFramework;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, AppDbContext>, ICategoryDal
    {
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }
    }
}
