using System;
using System.Collections.Generic;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public interface IRepository<TEntity, TId> : IDisposable
        where TEntity : BaseEntity<TId> 
        where TId : struct
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
