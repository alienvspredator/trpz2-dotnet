using System;
using System.Collections.Generic;

namespace WpfApp4.Models
{
    public partial class Book : BaseEntity<int>
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        public virtual Reader Reader { get; set; }
        public virtual ICollection<HistoryItem> History { get; set; } = new HashSet<HistoryItem>();
        public virtual ICollection<Charter> Charters { get; set; } = new HashSet<Charter>();
    }
}
