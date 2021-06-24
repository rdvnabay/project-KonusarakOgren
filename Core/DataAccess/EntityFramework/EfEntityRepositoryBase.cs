using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public class EfEntityRepositoryBase<TContext,TEntity> : IEntityRepository<TEntity>
        where TEntity:class,new()
        where TContext:DbContext,new()
    {
        //Command
        public void Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }

        //Query
        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(expression);
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(expression).ToList();
            }
        }
  
    }
}
