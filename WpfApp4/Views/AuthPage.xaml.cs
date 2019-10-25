using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp4.Core.Service;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Password;

            DbConnectionService.SetCredentials(username, password);
            var context = DbConnectionService.GetConnection();

            if (!DbConnectionService.TestConnection(context))
            {
                Console.WriteLine("Login error");
                return;
            }

            NavigationService.Navigate(new MainPage());
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
