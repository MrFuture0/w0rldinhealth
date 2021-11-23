using System.Collections.Generic;
using System.Linq;
using a.data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace a.data.Concrete.EfCore
{
    public class EfCoreGenericRepistory<TEntity, TContext> : IRepistory<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using(var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using(var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}