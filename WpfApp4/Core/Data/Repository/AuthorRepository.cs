using System.Collections.Generic;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Репозиторий авторов
    /// </summary>
    public class AuthorRepository : PersonRepository<Author>, IAuthorRepository
    {
        /// <summary>
        /// Инициализирует экземпляр класса AuthorRepository
        /// </summary>
        /// <param name="context">Контекст подключения к БД</param>
        public AuthorRepository(LibraryContext context) : base(context)
        {
        }

        /// <summary>
        /// Выбирает список авторов по книге
        /// </summary>
        /// <param name="book">Книга, по которой выполняется поиск</param>
        /// <returns>Список авторов</returns>
        public IEnumerable<Author> GetByBook(Book book)
        {
            IQueryable<Author> query = from a in Context.Set<Author>()
                                       where a.Books.Any(b => b.Id == book.Id)
                                       select a;

            return query.ToList();
        }
    }
}
