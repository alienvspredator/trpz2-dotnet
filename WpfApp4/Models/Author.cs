using System.Collections.Generic;

namespace WpfApp4.Models
{
    /// <summary>
    /// Автор книги
    /// </summary>
    public partial class Author : Person
    {
        /// <summary>
        /// Список книг автора
        /// </summary>
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
