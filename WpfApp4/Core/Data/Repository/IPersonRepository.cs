using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Интерфейс репозитория для дочерних сущностей Person
    /// </summary>
    /// <typeparam name="T">Дочерняя сущность Person</typeparam>
    public interface IPersonRepository<T> : IRepository<T> where T : Person
    {
        /// <summary>
        /// Поиск человека по имени
        /// </summary>
        /// <param name="name">Имя</param>
        /// <returns>Найденная сущность</returns>
        T GetByName(string name);
    }
}
