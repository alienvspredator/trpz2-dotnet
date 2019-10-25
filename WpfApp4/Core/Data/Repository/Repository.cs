using System.Collections.Generic;
using System.Data.Entity;

namespace WpfApp4.Core.Data.Repository
{
    public abstract class Repository<C, T> : IRepository<T>
        where T : class
        where C : DbContext
    {
        public Repository(C context)
        {
            Context = context;
        }

        protected C Context { get; set; }

        public virtual void Dispose()
        {
            Context.Dispose();
        }

        public abstract T Create(T entity);

        public abstract void Delete(T entity);

        public abstract IEnumerable<T> GetAll();

        public abstract T GetById(int id);

        public abstract void Update(T entity);
    }
}
