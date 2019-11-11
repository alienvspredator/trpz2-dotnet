namespace WpfApp4.Models
{
    /// <summary>
    /// Раздел книги
    /// </summary>
    public partial class Charter : BaseEntity
    {
        /// <summary>
        /// Заголовок раздела
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Книга, в котором находится раздел
        /// </summary>
        public virtual Book Book { get; set; }
    }
}
