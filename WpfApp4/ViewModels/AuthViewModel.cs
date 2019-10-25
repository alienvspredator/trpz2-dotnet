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

        private Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

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

        public bool HasErrors
        {
            get => errors.Values.FirstOrDefault(l => l.Count > 0) != null;
        }

        #endregion

        #region Events

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        #endregion

        #region Methods

        private void Validate()
        {
            if (!errors.TryGetValue("Name", out List<string> errorsList))
            {

            }
        }

        public void RaiseErrorsChanged(string propertyName)
        {
            EventHandler<DataErrorsChangedEventArgs> handler = ErrorsChanged;
            if (handler == null)
            {
                return;
            }

            var arg = new DataErrorsChangedEventArgs(propertyName);
            handler.Invoke(this, arg);
        }

        // TODO: Log in
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

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            errors.TryGetValue(propertyName, out List<string> errorsList);
            return errorsList;
        }

        #endregion
    }
}
