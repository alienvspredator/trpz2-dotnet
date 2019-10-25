using System.Collections.Generic;

namespace WpfApp4.Models
{
    public partial class Reader : Person
    {
        public Reader()
        {
            Book = new HashSet<Book>();
            History = new HashSet<HistoryItem>();
        }


        public virtual ICollection<Book> Book { get; set; }
        public virtual ICollection<HistoryItem> History { get; set; }
    }
}
