using System.Collections.Generic;

namespace WpfApp4.Models
{
    public partial class Reader : Person
    {
        public virtual ICollection<Book> Book { get; set; } = new HashSet<Book>();
        public virtual ICollection<HistoryItem> History { get; set; } = new HashSet<HistoryItem>();
        public virtual ReaderCard Card { get; set; }
    }
}
