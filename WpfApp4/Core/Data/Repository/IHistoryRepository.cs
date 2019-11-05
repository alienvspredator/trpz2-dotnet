using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    /// <summary>
    /// Интерфейс репозитория истории взятия книг
    /// </summary>
    public interface IHistoryRepository : IRepository<HistoryItem, int>
    {
    }
}
