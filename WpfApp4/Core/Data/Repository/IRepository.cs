using System.Collections.Generic;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public interface IRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TId id);
        TEntity Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
