using System.Collections.Generic;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Базовый интерфейс репозитория
    /// </summary>
    /// <typeparam name="TEntity">Сущность, дочерняя BaseEntity</typeparam>
    /// <typeparam name="TId">Тип ключа сущности</typeparam>
    public interface IRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        /// <summary>
        /// Поиск всех сущностей
        /// </summary>
        /// <returns>Все сущности</returns>
        IEnumerable<TEntity> GetAll();
        
        /// <summary>
        /// Поиск сущности по ID
        /// </summary>
        /// <param name="id">ID сущности</param>
        /// <returns>Найденная сущность</returns>
        TEntity GetById(TId id);

        /// <summary>
        /// Создание сущности в репозитории
        /// </summary>
        /// <param name="entity">Граф сущности</param>
        /// <returns>Созданная сущность</returns>
        TEntity Create(TEntity entity);

        /// <summary>
        /// Обновление сущности в репозиторий
        /// </summary>
        /// <param name="entity">Граф обновляемой сущности</param>
        void Update(TEntity entity);

        /// <summary>
        /// Удаление сущности из репозитория
        /// </summary>
        /// <param name="entity">Удаляемая сущность</param>
        void Delete(TEntity entity);
    }
}
