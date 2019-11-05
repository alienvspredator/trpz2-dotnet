using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    /// <summary>
    /// Валидатор книги
    /// </summary>
    public class BookValidator : IEntityValidator<Book, int>
    {
        private Book ValidableBook { get; set; }

        /// <summary>
        /// Инициализирует экземпляр валидатора книги
        /// </summary>
        /// <param name="book">Книга для валидации</param>
        public BookValidator(Book book)
        {
            ValidableBook = book;
        }

        private bool IsAuthorsListValid()
        {
            return ValidableBook.Authors != null;
        }

        private bool IsAuthorsListNotEmpty()
        {
            return IsAuthorsListValid() && ValidableBook.Authors.Count > 0;
        }

        private bool ValidateAuthors()
        {
            return IsAuthorsListNotEmpty();
        }

        private bool ValidateTitle()
        {
            return !string.IsNullOrWhiteSpace(ValidableBook.Name);
        }

        private bool ValidateReleaseDate()
        {
            return ValidableBook.ReleaseDate != null;
        }


        /// <summary>
        /// Производит валидацию
        /// </summary>
        /// <returns>Прошла ли книга валидацию</returns>
        public bool Validate()
        {
            return ValidateAuthors() && ValidateTitle() && ValidateReleaseDate();
        }
    }
}
