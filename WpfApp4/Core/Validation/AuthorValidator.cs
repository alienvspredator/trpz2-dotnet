using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    /// <summary>
    /// Валидация автора
    /// </summary>
    public class AuthorValidator : PersonValidator<Author>
    {
        /// <summary>
        /// Инициализирует экземпляр валидатора
        /// </summary>
        /// <param name="author">Автор, который валидуется</param>
        public AuthorValidator(Author author) : base(author)
        {
        }
    }
}
