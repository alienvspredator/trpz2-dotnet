using System;
using System.Collections.Generic;

namespace WpfApp4.Models
{
    /// <summary>
    /// Книга
    /// </summary>
    public partial class Book : BaseEntity
    {
        /// <summary>
        /// Название книги
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Дата релиза
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Список авторов
        /// </summary>
        public virtual ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        
        /// <summary>
        /// Читатель, у которого находится книга в данный момент
        /// </summary>
        public virtual Reader Reader { get; set; }

        /// <summary>
        /// История взятия книги читателями
        /// </summary>
        public virtual ICollection<HistoryItem> History { get; set; } = new HashSet<HistoryItem>();

        /// <summary>
        /// Разделы книги
        /// </summary>
        public virtual ICollection<Charter> Charters { get; set; } = new HashSet<Charter>();
    }
}
