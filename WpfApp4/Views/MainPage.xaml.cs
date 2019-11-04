using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Readers_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Page readersPage = new ReadersListPage();
            NavigationService.Navigate(readersPage);
        }
        private void Books_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Page booksPage = new BooksListPage();
            NavigationService.Navigate(booksPage);
        }
    }
}
