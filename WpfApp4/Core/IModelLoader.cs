using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;
using System.Collections.ObjectModel;

namespace WpfApp4.Core
{
    public interface IModelLoader
    {
        ObservableCollection<Author> LoadAuthors();

        ObservableCollection<Book> LoadBooks();

        ObservableCollection<Reader> LoadReaders();
    }
}
