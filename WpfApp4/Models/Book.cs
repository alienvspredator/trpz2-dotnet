using System;
using System.Collections.Generic;

namespace WpfApp4.Models
{
    public partial class Book : BaseEntity<int>
    {
        public Book()
        {
            Authors = new HashSet<Author>();
            History = new HashSet<HistoryItem>();
            Charters = new HashSet<Charter>();
        }
        
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual Reader Reader { get; set; }
        public virtual ICollection<HistoryItem> History { get; set; }
        public virtual ICollection<Charter> Charters { get; set; }
    }
}
