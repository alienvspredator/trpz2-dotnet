using System;

namespace WpfApp4.Models
{
    public partial class HistoryItem : BaseEntity<int>
    {
        public DateTime ReturnedDate { get; set; }
        public DateTime? RealReturnedDate { get; set; }
        public DateTime TakenDate { get; set; }
        public string Status { get; set; }

        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
