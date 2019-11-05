using System.Collections.Generic;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Интерфейс репозитория автора
    /// </summary>
    public interface IAuthorRepository : IPersonRepository<Author>
    {
        /// <summary>
        /// Позволяет получить список авторов по книге
        /// </summary>
        /// <param name="book">Книга, по которой выполняется поиск</param>
        /// <returns>Список найденных книг</returns>
        IEnumerable<Author> GetByBook(Book book);
    }
}
