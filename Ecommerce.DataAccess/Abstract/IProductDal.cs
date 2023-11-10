using Ecommerce.Core.DataAccess;
using Ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Abstract
{
    public interface IProductDal : IRepositoryBase<Product>
    {
    }
}
