using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;
using System.Data.Entity;

namespace WpfApp4.Core.Data.Repository
{
    public class HistoryRepository : Repository<LibraryContext, HistoryItem>, IHistoryRepository
    {
        public HistoryRepository(LibraryContext context) : base(context)
        {
        }

        public override HistoryItem Create(HistoryItem entity)
        {
            HistoryItem historyItem = Context.History.Add(entity);
            Context.SaveChanges();
            return historyItem;
        }

        public override void Delete(HistoryItem entity)
        {
            Context.History.Remove(entity);
            Context.SaveChanges();
        }

        public override IEnumerable<HistoryItem> GetAll()
        {
            return Context.History.ToList();
        }

        //public override HistoryItem GetById(int id)
        //{
        //    return Context.History.Find(id);
        //}

        public override void Update(HistoryItem entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
