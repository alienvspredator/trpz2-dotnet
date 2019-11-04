namespace WpfApp4.Models
{
    public partial class ReaderCard : BaseEntity<int>
    {
        public virtual Reader Owner { get; set; }
    }
}
