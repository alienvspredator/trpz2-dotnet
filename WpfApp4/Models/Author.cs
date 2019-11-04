using System.Collections.Generic;

namespace WpfApp4.Models
{
    public partial class Author : Person
    {
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
