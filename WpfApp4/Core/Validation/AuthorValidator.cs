using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    public class AuthorValidator : PersonValidator<Author>
    {
        public AuthorValidator(Author author) : base(author)
        {
        }
    }
}
