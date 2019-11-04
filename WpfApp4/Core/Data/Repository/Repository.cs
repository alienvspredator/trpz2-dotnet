using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public abstract class Repository<TContext, TEntity> : IRepository<TEntity, int>, IDisposable
        where TContext : DbContext
        where TEntity : BaseEntity<int>
    {
        private bool disposed = false;

        public Repository(TContext context)
        {
            Context = context;
        }

        protected TContext Context { get; set; }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Context.Dispose();
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public abstract TEntity Create(TEntity entity);

        public abstract void Delete(TEntity entity);

        public abstract IEnumerable<TEntity> GetAll();

        public virtual TEntity GetById(int id)
        {
            IQueryable<TEntity> query = from e in Context.Set<TEntity>()
                                        where e.Id == id
                                        select e;

            return query.FirstOrDefault();
        }

        public abstract void Update(TEntity entity);
    }
}
