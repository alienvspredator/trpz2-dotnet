using System.Collections.Generic;
using System.Linq;
using WpfApp4.Models;
using System.Data.Entity;

namespace WpfApp4.Core.Data.Repository
{
    public class PersonRepository : Repository<LibraryContext, Person>, IPersonRepository<Person>
    {
        public PersonRepository(LibraryContext context) : base(context)
        {
        }

        override public Person Create(Person entity)
        {
            Person person = Context.People.Add(entity);
            Context.SaveChanges();
            return person;
        }

        override public void Delete(Person entity)
        {
            Context.People.Remove(entity);
            Context.SaveChanges();
        }

        override public IEnumerable<Person> GetAll()
        {
            return Context.People.ToList();
        }

        //override public Person GetById(int id)
        //{
        //    return Context.People.Find(id);
        //}

        public Person GetByName(string name)
        {
            var query = from p in Context.People
                        where p.Name == name
                        select p;
            return query.FirstOrDefault();
        }

        override public void Update(Person entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
