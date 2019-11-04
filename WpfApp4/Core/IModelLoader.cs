using System.Collections.ObjectModel;
using WpfApp4.Models;

namespace WpfApp4.Core
{
    public interface IModelLoader
    {
        ObservableCollection<Author> LoadAuthors();

        ObservableCollection<Book> LoadBooks();

        ObservableCollection<Reader> LoadReaders();
    }
}
