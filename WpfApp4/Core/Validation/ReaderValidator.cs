using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    /// <summary>
    /// Валидатор читателя
    /// </summary>
    public class ReaderValidator : PersonValidator<Reader>
    {
        /// <summary>
        /// Инициализирует экземпляр валидатора читателя
        /// </summary>
        /// <param name="reader">Читатель, который валидуется</param>
        public ReaderValidator(Reader reader) : base(reader)
        {
        }
    }
}
