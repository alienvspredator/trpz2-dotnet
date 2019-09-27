using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Core
{
    public class Author : Person
    {
        public Author(string name, string surname, List<Book> books) : base(name, surname)
        {
            Books = books;
        }

        public List<Book> Books { get; set; }
    }
}
