using System;
using System.Collections.Generic;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Интерфейс репозитория книг
    /// </summary>
    public interface IBookRepository : IRepository<Book>
    {
        /// <summary>
        /// Выполняет поиск книг по дате релиза
        /// </summary>
        /// <param name="date">Дата релиза книги</param>
        /// <returns>Список найденных книг</returns>
        IEnumerable<Book> GetByReleaseDate(DateTime date);

        /// <summary>
        /// Выполняет поиск книги по названию
        /// </summary>
        /// <param name="title">Название книги</param>
        /// <returns>Найденная книга</returns>
        Book GetByTitle(string title);
    }
}
