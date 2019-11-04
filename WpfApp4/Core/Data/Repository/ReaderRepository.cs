using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;
using System.Data.Entity;

namespace WpfApp4.Core.Data.Repository
{
    public class ReaderRepository : Repository<LibraryContext, Reader>, IReaderRepository
    {
        public ReaderRepository(LibraryContext context) : base(context)
        {
        }

        public override Reader Create(Reader entity)
        {
            Reader reader = Context.People.Add(entity) as Reader;
            Context.SaveChanges();
            return reader;
        }

        public override void Delete(Reader entity)
        {
            Context.People.Remove(entity);
            Context.SaveChanges();
        }

        public override IEnumerable<Reader> GetAll()
        {
            return Context.People.OfType<Reader>().ToList();
        }

        //public override Reader GetById(int id)
        //{
        //    return Context.People.Find(id) as Reader;
        //}

        public Reader GetByName(string name)
        {
            var query = from p in Context.People
                        where p.Name == name
                        select p;
            return query.OfType<Reader>().FirstOrDefault();
        }

        public override void Update(Reader entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
