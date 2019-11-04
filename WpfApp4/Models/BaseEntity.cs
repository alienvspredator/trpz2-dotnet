namespace WpfApp4.Models
{
    public abstract class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }
    }
}
