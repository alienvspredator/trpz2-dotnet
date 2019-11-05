using System;

namespace WpfApp4.Models
{
    /// <summary>
    /// История взятия книги читателями
    /// </summary>
    public partial class HistoryItem : BaseEntity<int>
    {
        /// <summary>
        /// Дата возврата книги (предполагаемая)
        /// </summary>
        public DateTime ReturnedDate { get; set; }

        /// <summary>
        /// Дата, когда книга была возвращена на самом деле
        /// </summary>
        public DateTime? RealReturnedDate { get; set; }

        /// <summary>
        /// Дата, когда книга была взята
        /// </summary>
        public DateTime TakenDate { get; set; }
        
        /// <summary>
        /// Статус записи в истории
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Книга
        /// </summary>
        public virtual Book Book { get; set; }

        /// <summary>
        /// Читатель
        /// </summary>
        public virtual Reader Reader { get; set; }
    }
}
