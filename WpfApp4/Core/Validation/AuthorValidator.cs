using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    class AuthorValidator : IEntityValidator
    {
        private Author ValidableAuthor { get; set; }

        public AuthorValidator(Author author)
        {
            ValidableAuthor = author;
        }

        private bool ValidateName()
        {
            return !string.IsNullOrWhiteSpace(ValidableAuthor.Name);
        }

        private bool ValidateSurname()
        {
            return !string.IsNullOrWhiteSpace(ValidableAuthor.Surname);
        }

        public bool Validate()
        {
            return ValidateName() && ValidateSurname();
        }
    }
}
