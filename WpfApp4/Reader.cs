using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Reader
    {
        public Reader(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        private string name;
        private string surname;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
    }
}
