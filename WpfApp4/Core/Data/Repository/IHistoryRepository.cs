﻿using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public interface IHistoryRepository : IRepository<HistoryItem, int>
    {
        // IEnumerable<HistoryItem> GetByBook(Book book);

        // IEnumerable<HistoryItem> GetByReader(Reader reader);
    }
}
