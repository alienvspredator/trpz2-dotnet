using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Репозиторий читателя
    /// </summary>
    public class ReaderRepository : PersonRepository<Reader>, IReaderRepository
    {
        /// <summary>
        /// Инициализирует репозиторий читателя
        /// </summary>
        /// <param name="context">Контекст БД библиотеки</param>
        public ReaderRepository(LibraryContext context) : base(context)
        {
        }
    }
}
