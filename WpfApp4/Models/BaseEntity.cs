using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp4.Models
{
    /// <summary>
    /// Базовый класс сущностей модели
    /// </summary>
    /// <typeparam name="T">Тип первичного ключа сущностей, передаваемый по значению</typeparam>
    public abstract class BaseEntity<T> where T : struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
    }
}
