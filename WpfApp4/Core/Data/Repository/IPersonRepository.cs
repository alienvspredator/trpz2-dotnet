using WpfApp4.Models;

namespace WpfApp4.Core.Data.Repository
{
    public interface IPersonRepository<T> : IRepository<T> where T : Person
    {
        T GetByName(string name);
    }
}
