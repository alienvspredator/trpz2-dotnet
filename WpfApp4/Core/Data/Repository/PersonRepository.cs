using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Базовый класс репозитория сущностей, дочерних от Person
    /// </summary>
    /// <typeparam name="TPersonEntity">Тип дочерней сущности</typeparam>
    public abstract class PersonRepository<TPersonEntity> : Repository<LibraryContext, TPersonEntity, int>, IPersonRepository<TPersonEntity>
        where TPersonEntity : Person
    {
        /// <summary>
        /// Инициализирует репозиторий
        /// </summary>
        /// <param name="context">Контекст БД библиотеки</param>
        protected PersonRepository(LibraryContext context) : base(context)
        {
        }

        /// <summary>
        /// Поиск сущности по имени
        /// </summary>
        /// <param name="name">Имя сущности</param>
        /// <returns>Найденная сущность</returns>
        public TPersonEntity GetByName(string name)
        {
            IQueryable<TPersonEntity> query = from p in Context.Set<TPersonEntity>()
                                              where p.Name == name
                                              select p;
            return query.FirstOrDefault();
        }
    }
}
