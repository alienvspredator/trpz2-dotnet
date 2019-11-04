using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public interface IBookRepository : IRepository<Book, int>
    {
        // IEnumerable<Book> GetByAuthor(Author author);

        IEnumerable<Book> GetByReleaseDate(DateTime date);

        Book GetByTitle(string title);
    }
}
