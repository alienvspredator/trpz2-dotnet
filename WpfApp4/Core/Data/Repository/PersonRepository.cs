using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public class PersonRepository : Repository<LibraryContext, Person>, IPersonRepository<Person>
    {
        public PersonRepository(LibraryContext context) : base(context)
        {
        }

        public override Person Create(Person entity)
        {
            Person person = Context.People.Add(entity);
            Context.SaveChanges();
            return person;
        }

        public override void Delete(Person entity)
        {
            Context.People.Remove(entity);
            Context.SaveChanges();
        }

        public override IEnumerable<Person> GetAll()
        {
            return Context.People.ToList();
        }

        //override public Person GetById(int id)
        //{
        //    return Context.People.Find(id);
        //}

        public Person GetByName(string name)
        {
            IQueryable<Person> query = from p in Context.People
                                       where p.Name == name
                                       select p;
            return query.FirstOrDefault();
        }

        public override void Update(Person entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
