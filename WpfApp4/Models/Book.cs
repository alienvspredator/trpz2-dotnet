using System;
using System.Collections.Generic;

namespace WpfApp4.Models
{
    public partial class Book
    {
        public Book()
        {
            Authors = new HashSet<Author>();
            History = new HashSet<HistoryItem>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual Reader Reader { get; set; }
        public virtual ICollection<HistoryItem> History { get; set; }
    }
}
