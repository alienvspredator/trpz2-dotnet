using System.Collections.Generic;

namespace WpfApp4.Models
{
    /// <summary>
    /// Читатель
    /// </summary>
    public partial class Reader : Person
    {
        /// <summary>
        /// Список книг, которые находятся у читателя
        /// </summary>
        public virtual ICollection<Book> Book { get; set; } = new HashSet<Book>();

        /// <summary>
        /// История взятия книг читателем
        /// </summary>
        public virtual ICollection<HistoryItem> History { get; set; } = new HashSet<HistoryItem>();

        /// <summary>
        /// Карта читателя
        /// </summary>
        public virtual ReaderCard Card { get; set; }
    }
}
