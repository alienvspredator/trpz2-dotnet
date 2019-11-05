using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public class HistoryRepository : Repository<LibraryContext, HistoryItem, int>, IHistoryRepository
    {
        public HistoryRepository(LibraryContext context) : base(context)
        {
        }
    }
}
