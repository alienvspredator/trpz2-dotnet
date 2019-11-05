using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Репозиторий книг
    /// </summary>
    public class BookRepository : Repository<LibraryContext, Book, int>, IBookRepository
    {
        /// <summary>
        /// Инициализирует экземпляр репозитория
        /// </summary>
        /// <param name="context"></param>
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        /// <summary>
        /// Ищет книги по дате релиза
        /// </summary>
        /// <param name="date">Дата релиза книги</param>
        /// <returns>Список найденных книг</returns>
        public IEnumerable<Book> GetByReleaseDate(DateTime date)
        {
            IQueryable<Book> query = from b in Context.Books
                                     where b.ReleaseDate == date
                                     select b;
            return query.ToList();
        }

        /// <summary>
        /// Позволяет выполнить поиск по книги по заголовку
        /// </summary>
        /// <param name="title">Заголовок книги</param>
        /// <returns>Найденная книга</returns>
        public Book GetByTitle(string title)
        {
            IQueryable<Book> query = from b in Context.Books
                                     where b.Name == title
                                     select b;
            return query.FirstOrDefault();
        }
    }
}
