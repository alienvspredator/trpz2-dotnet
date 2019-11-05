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

        public TPersonEntity GetByName(string name)
        {
            IQueryable<TPersonEntity> query = from p in Context.Set<TPersonEntity>()
                                              where p.Name == name
                                              select p;
            return query.FirstOrDefault();
        }
    }
}
