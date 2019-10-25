using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    class ReaderValidator : IEntityValidator
    {
        private Reader ValidableReader { get; set; }

        public ReaderValidator(Reader reader)
        {
            ValidableReader = reader;
        }

        private bool ValidateName()
        {
            return !string.IsNullOrWhiteSpace(ValidableReader.Name);
        }

        private bool ValidateSurname()
        {
            return !string.IsNullOrWhiteSpace(ValidableReader.Surname);
        }

        public bool Validate()
        {
            return ValidateName() && ValidateSurname();
        }
    }
}
