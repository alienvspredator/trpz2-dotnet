using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Репозиторий истории взятия книги
    /// </summary>
    public class HistoryRepository : Repository<LibraryContext, HistoryItem, int>, IHistoryRepository
    {
        /// <summary>
        /// Инициализирует экземпляр репозитория истории
        /// </summary>
        /// <param name="context">Контекст БД библиотеки</param>
        public HistoryRepository(LibraryContext context) : base(context)
        {
        }
    }
}
