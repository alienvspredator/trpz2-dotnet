using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp4.Core.Service;
using WpfApp4.Models;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        private LibraryContext Context { get; set; }

        public AuthPage()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Password;

            DbConnectionService.SetCredentials(username, password);
            Context = DbConnectionService.GetConnection();

            if (!DbConnectionService.TestConnection(Context))
            {
                Console.WriteLine("Login error");
                return;
            }

            NavigationService.Navigate(new MainPage(Context));
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
