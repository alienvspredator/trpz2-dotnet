using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Core
{
    public class Book
    {
        public Book(string name)
        {
            Name = name;
        }

        private string name;

        public string Name { get => name; set => name = value; }
        public string ReleaseDate { get; set; } = "1984-03-22";
    }
}
