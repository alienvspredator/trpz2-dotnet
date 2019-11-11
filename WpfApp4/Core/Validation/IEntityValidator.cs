using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    /// <summary>
    /// Интерфейс валидатора сущности
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности, дочерней от BaseEntity</typeparam>
    /// <typeparam name="T">Тип первичного ключа сущности</typeparam>
    public interface IEntityValidator<TEntity>
        where TEntity : BaseEntity
    {
        /// <summary>
        /// Производит валидацию сущности
        /// </summary>
        /// <returns>Прошла ли сущность валидацю</returns>
        bool Validate();
    }
}
