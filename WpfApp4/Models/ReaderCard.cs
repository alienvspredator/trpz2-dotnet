namespace WpfApp4.Models
{
    public partial class ReaderCard : BaseEntity<int>
    {
        /// <summary>
        /// Владелец карты читателя
        /// </summary>
        public virtual Reader Owner { get; set; }
    }
}
