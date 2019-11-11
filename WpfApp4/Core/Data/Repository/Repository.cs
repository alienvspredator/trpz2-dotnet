using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Базовый класс репозитория
    /// </summary>
    /// <typeparam name="TContext">Тип контекста БД</typeparam>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    public abstract class Repository<TContext, TEntity> : IRepository<TEntity>, IDisposable
        where TContext : DbContext
        where TEntity : BaseEntity
    {
        private bool disposed = false;

        /// <summary>
        /// Инициализирует репозиторий
        /// </summary>
        /// <param name="context">Контекст БД</param>
        protected Repository(TContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Контекст БД
        /// </summary>
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

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Создание сущности
        /// </summary>
        /// <param name="entity">Граф создаваемой сущности</param>
        /// <returns>Созданная сущность</returns>
        public virtual TEntity Create(TEntity entity)
        {
            TEntity insertedEntity = Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
            return insertedEntity;
        }

        /// <summary>
        /// Удаление сущности
        /// </summary>
        /// <param name="entity">Удаляемая сущность</param>
        public virtual void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        /// <summary>
        /// Получение списка всех сущностей
        /// </summary>
        /// <returns>Список сущностей</returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = from e in Context.Set<TEntity>()
                                        select e;

            return query.ToList();
        }

        /// <summary>
        /// Поиск сущности по ID
        /// </summary>
        /// <param name="id">ID сущности</param>
        /// <returns>Найденная сущность</returns>
        public virtual TEntity GetById(int id)
        {
            IQueryable<TEntity> query = from e in Context.Set<TEntity>()
                                        where e.Id == id
                                        select e;

            return query.FirstOrDefault();
        }

        /// <summary>
        /// Обновление сущности в репозитории
        /// </summary>
        /// <param name="entity">Обновляемая сущность</param>
        public virtual void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
