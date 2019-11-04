namespace WpfApp4.Models
{
    public partial class Charter : BaseEntity<int>
    {
        public string Title { get; set; }

        public virtual Book Book { get; set; }
    }
}
