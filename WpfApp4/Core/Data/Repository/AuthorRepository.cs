using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public class AuthorRepository : Repository<Library, Author>, IAuthorRepository
    {
        public AuthorRepository(Library context) : base(context)
        {
        }

        public override Author Create(Author entity)
        {

            Author author = Context.People.Add(entity) as Author;
            Context.SaveChanges();
            return author;
        }

        public override void Delete(Author entity)
        {
            Context.People.Remove(entity);
            Context.SaveChanges();
        }

        public override IEnumerable<Author> GetAll()
        {
            return Context.People.OfType<Author>().ToList();
        }

        public override Author GetById(int id)
        {
            return Context.People.Find(id) as Author;
        }

        public Author GetByName(string name)
        {
            var query = from p in Context.People
                        where p.Name == name
                        select p;
            return query.OfType<Author>().FirstOrDefault();
        }

        public override void Update(Author entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
