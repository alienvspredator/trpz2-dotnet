using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public abstract class PersonRepository<TPersonEntity> : Repository<LibraryContext, TPersonEntity, int>, IPersonRepository<TPersonEntity>
        where TPersonEntity : Person
    {
        protected PersonRepository(LibraryContext context) : base(context)
        {
        }

        public override TPersonEntity Create(TPersonEntity entity)
        {
            TPersonEntity insertedEntity = Context.Set<TPersonEntity>().Add(entity);
            Context.SaveChanges();
            return insertedEntity;
        }

        public override void Delete(TPersonEntity entity)
        {
            Context.Set<TPersonEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public override IEnumerable<TPersonEntity> GetAll()
        {
            return Context.Set<TPersonEntity>().ToList();
        }

        //override public Person GetById(int id)
        //{
        //    return Context.People.Find(id);
        //}

        public TPersonEntity GetByName(string name)
        {
            IQueryable<TPersonEntity> query = from p in Context.Set<TPersonEntity>()
                                              where p.Name == name
                                              select p;
            return query.FirstOrDefault();
        }

        public override void Update(TPersonEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
