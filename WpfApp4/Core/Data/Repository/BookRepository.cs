using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public class BookRepository : Repository<LibraryContext, Book>, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        public override Book Create(Book entity)
        {
            Book book = Context.Books.Add(entity);
            Context.SaveChanges();
            return book;
        }

        public override void Delete(Book entity)
        {
            Context.Books.Remove(entity);
            Context.SaveChanges();
        }

        public override IEnumerable<Book> GetAll()
        {
            return Context.Books.ToList();
        }

        //public override Book GetById(int id)
        //{
        //    return Context.Books.Find(id);
        //}

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

        public override void Update(Book entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
