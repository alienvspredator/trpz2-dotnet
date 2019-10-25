using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    public class BookValidator : IEntityValidator
    {
        private Book ValidableBook { get; set; }

        public BookValidator(Book book)
        {
            ValidableBook = book;
        }

        private bool ValidateAuthors()
        {
            return ValidableBook.Authors != null && ValidableBook.Authors.Count > 0;
        }

        private bool ValidateTitle()
        {
            return !string.IsNullOrWhiteSpace(ValidableBook.Name);
        }

        private bool ValidateReleaseDate()
        {
            return ValidableBook.ReleaseDate != null;
        }

        public bool Validate()
        {
            return ValidateAuthors() && ValidateTitle();
        }
    }
}
