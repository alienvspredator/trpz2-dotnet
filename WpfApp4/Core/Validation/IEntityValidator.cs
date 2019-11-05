using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    /// <summary>
    /// Интерфейс валидатора сущности
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности, дочерней от BaseEntity</typeparam>
    /// <typeparam name="T">Тип первичного ключа сущности</typeparam>
    public interface IEntityValidator<TEntity, T>
        where TEntity : BaseEntity<T>
        where T : struct
    {
        /// <summary>
        /// Производит валидацию сущности
        /// </summary>
        /// <returns>Прошла ли сущность валидацю</returns>
        bool Validate();
    }
}
