using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Core;
using System.Windows.Input;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WpfApp4.ViewModels
{
    class AuthViewModel : BaseViewModel, INotifyDataErrorInfo
    {
        #region Fields

        private bool isAuthentificated;

        private string username;

        private string password;

        #endregion

        #region Properties

        public bool IsAuthentificated
        {
            get => isAuthentificated;
            set
            {
                isAuthentificated = value;
                OnPropertyChanged("IsAuthentificated");
            }
        }

        public string Username
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password
        {
            private get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public ICommand LoginCommand
        {
            get => new RelayCommand(obj => Login() );
        }

        #endregion

        public void Login()
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                try
                {

                } catch
                {

                }
            }
        }

        public List<ValidationResult> ErrorsContainer { get; set; } = new List<ValidationResult>();

        public IEnumerable GetErrors(string propertyName)
        {
            return ErrorsContainer
        }

        public bool HasErrors
        {
            get => ErrorsContainer.Count > 0;
        }
    }
}
