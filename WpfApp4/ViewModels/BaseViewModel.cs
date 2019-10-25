using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp4.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void RaisePropertyChanged([CallerMemberName] string caller = null)
        {
            OnPropertyChanged(caller);
        }
    }
}
