using System.Collections.Generic;

namespace WpfApp4.Models
{
    public partial class Author : Person
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }


        public virtual ICollection<Book> Books { get; set; }
    }
}
