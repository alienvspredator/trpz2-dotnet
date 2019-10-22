using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Core;
using System.Collections.ObjectModel;
using WpfApp4.Models;
using System.Data.SqlClient;

namespace WpfApp4.Network
{
    public class DatabaseModelLoader : IModelLoader
    {
        private readonly trpzEntities dbContext;

        public ObservableCollection<Author> LoadAuthors()
        {
            return new ObservableCollection<Author>(dbContext.People.OfType<Author>());
        }

        public ObservableCollection<Book> LoadBooks()
        {
            return new ObservableCollection<Book>(dbContext.Books);
        }

        public ObservableCollection<Reader> LoadReaders()
        {
            return new ObservableCollection<Reader>(dbContext.People.OfType<Reader>());
        }

        public DatabaseModelLoader(string username, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                ["Server"] = "localhost",
                ["Connect Timeout"] = 1000,
                ["Trusted_Connection"] = true,
                ["User"] = username
            };

            builder.Password = password;
            builder.AsynchronousProcessing = true;
            dbContext = new trpzEntities(builder.ConnectionString);
        }
    }
}
