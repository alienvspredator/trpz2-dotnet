namespace WpfApp4.Models
{
    /// <summary>
    /// Базовый класс для людей
    /// </summary>
    public abstract class Person : BaseEntity<int>
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
    }
}
