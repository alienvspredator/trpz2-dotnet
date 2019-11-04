using WpfApp4.Models;

namespace WpfApp4.ViewModels
{
    internal class AuthorDetailsViewModel : BaseViewModel
    {
        #region Fields

        private Author currentAuthor;

        #endregion

        #region Properties

        public Author Author
        {
            get => currentAuthor;
            set
            {
                currentAuthor = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
