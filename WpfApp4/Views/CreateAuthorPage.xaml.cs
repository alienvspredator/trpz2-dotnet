using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
