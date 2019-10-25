using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;
    
namespace WpfApp4.Core.Data.Repository
{
    public interface IHistoryRepository : IRepository<HistoryItem>
    {
        // IEnumerable<HistoryItem> GetByBook(Book book);

        // IEnumerable<HistoryItem> GetByReader(Reader reader);
    }
}
