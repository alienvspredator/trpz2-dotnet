using System.Collections.Generic;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public interface IAuthorRepository : IPersonRepository<Author>
    {
        IEnumerable<Author> GetByBook(Book book);
    }
}
