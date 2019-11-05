using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfApp4.Models;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private LibraryContext Context { get; set; }

        public MainPage(LibraryContext context)
        {
            InitializeComponent();
            Context = context;
        }
        private void Readers_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Page readersPage = new ReadersListPage(Context);
            NavigationService.Navigate(readersPage);
        }
        private void Books_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Page booksPage = new BooksListPage(Context);
            NavigationService.Navigate(booksPage);
        }
    }
}
