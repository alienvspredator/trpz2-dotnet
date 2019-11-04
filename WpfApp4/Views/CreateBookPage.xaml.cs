using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp4.Models;
using WpfApp4.Core.Service;
using WpfApp4.Core.Data.Repository;
using WpfApp4.ViewModels;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateBookPage.xaml
    /// </summary>
    public partial class CreateBookPage : Page
    {
        private LibraryContext Context { get; }

        public CreateBookPage(Book bookToEdit, LibraryContext context)
        {
            InitializeComponent();
            Context = context;

            CreateBookViewModel viewModel = new CreateBookViewModel(new BookRepository(Context), bookToEdit);
            Submit.Command = viewModel.UpdateBookCommand;

            DataContext = viewModel;
        }

        public CreateBookPage(LibraryContext context)
        {
            InitializeComponent();
            Context = context;

            CreateBookViewModel viewModel = new CreateBookViewModel(new BookRepository(Context));
            Submit.Command = viewModel.CreateBookCommand;

            DataContext = viewModel;
        }

        private void CreateAuthor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateAuthorPage(Context));
        }

        private void RemoveAuthor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddAuthorToBook_Click(object sender, RoutedEventArgs e)
        {
            AuthorListPage authorListPage = new AuthorListPage(DataContext as CreateBookViewModel, Context);
            NavigationService.Navigate(authorListPage);
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
