using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp4.Models;
using WpfApp4.ViewModels;
using WpfApp4.Core.Data.Repository;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateAuthorPage.xaml
    /// </summary>
    public partial class CreateAuthorPage : Page
    {
        private Library Context { get; }

        public CreateAuthorPage(Author authorToEdit, Library context)
        {
            InitializeComponent();
            Context = context;

            CreateAuthorViewModel viewModel = new CreateAuthorViewModel(new AuthorRepository(Context), authorToEdit);
            Submit.Command = viewModel.UpdateAuthorCommand;

            DataContext = viewModel;
        }

        public CreateAuthorPage(Library context)
        {
            InitializeComponent();
            Context = context;

            CreateAuthorViewModel viewModel = new CreateAuthorViewModel(new AuthorRepository(Context));
            Submit.Command = viewModel.CreateAuthorCommand;

            DataContext = viewModel;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
