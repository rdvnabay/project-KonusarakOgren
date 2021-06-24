using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity>
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>>expression);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>expression=null);
    }
}
