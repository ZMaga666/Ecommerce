using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.DataAccess
{
    public interface IRepositoryBase<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> entity);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> ? entity = null);

    }
}
