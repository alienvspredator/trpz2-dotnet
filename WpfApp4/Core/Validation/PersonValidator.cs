using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    /// <summary>
    /// Валидатор сущности, дочерней от Person
    /// </summary>
    /// <typeparam name="TPerson">Тип сущности, дочерней от Person</typeparam>
    public class PersonValidator<TPerson> : IEntityValidator<TPerson> where TPerson : Person
    {
        private TPerson ValidablePerson { get; set; }

        /// <summary>
        /// Инициалиирует экземпляр валидатора
        /// </summary>
        /// <param name="person">Сущность для валидации</param>
        public PersonValidator(TPerson person)
        {
            ValidablePerson = person;
        }

        /// <summary>
        /// Производит валидацию имени сущности
        /// </summary>
        /// <returns>Прошло ли имя валидацию</returns>
        protected virtual bool ValidateName()
        {
            return !string.IsNullOrWhiteSpace(ValidablePerson.Name);
        }

        /// <summary>
        /// Производит валидацию фамилии сущности
        /// </summary>
        /// <returns>Прошла ли фамилия валидацю</returns>
        protected virtual bool ValidateSurname()
        {
            return !string.IsNullOrWhiteSpace(ValidablePerson.Surname);
        }

        /// <summary>
        /// Производит полную валидацию сущности
        /// </summary>
        /// <returns>Прошла ли сущность валидацию</returns>
        public virtual bool Validate()
        {
            return ValidateName() && ValidateSurname();
        }
    }
}
