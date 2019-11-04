namespace WpfApp4.Models
{
    public abstract class Person : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
