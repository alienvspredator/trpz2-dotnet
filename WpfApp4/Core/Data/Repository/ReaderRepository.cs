using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public class ReaderRepository : PersonRepository<Reader>, IReaderRepository
    {
        public ReaderRepository(LibraryContext context) : base(context)
        {
        }
    }
}
