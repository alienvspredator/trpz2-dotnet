using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    public class PersonValidator<T> : IEntityValidator where T : Person
    {
        private T ValidablePerson { get; set; }

        public PersonValidator(T person)
        {
            ValidablePerson = person;
        }

        protected virtual bool ValidateName()
        {
            return !string.IsNullOrWhiteSpace(ValidablePerson.Name);
        }

        protected virtual bool ValidateSurname()
        {
            return !string.IsNullOrWhiteSpace(ValidablePerson.Surname);
        }

        public virtual bool Validate()
        {
            return ValidateName() && ValidateSurname();
        }
    }
}
