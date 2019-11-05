using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public class BookRepository : Repository<LibraryContext, Book, int>, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        public IEnumerable<Book> GetByReleaseDate(DateTime date)
        {
            IQueryable<Book> query = from b in Context.Books
                                     where b.ReleaseDate == date
                                     select b;
            return query.ToList();
        }

        public Book GetByTitle(string title)
        {
            IQueryable<Book> query = from b in Context.Books
                                     where b.Name == title
                                     select b;
            return query.FirstOrDefault();
        }
    }
}
