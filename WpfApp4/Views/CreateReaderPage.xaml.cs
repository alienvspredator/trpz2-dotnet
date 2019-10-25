using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp4.Models;
using WpfApp4.ViewModels;
using WpfApp4.Core.Data.Repository;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateReaderPage.xaml
    /// </summary>
    public partial class CreateReaderPage : Page
    {
        private Library Context { get; }

        public CreateReaderPage(Reader readerToEdit, Library context)
        {
            InitializeComponent();
            Context = context;

            CreateReaderViewModel viewModel = new CreateReaderViewModel(new ReaderRepository(Context), readerToEdit);
            Submit.Command = viewModel.UpdateReaderCommand;

            DataContext = viewModel;
        }

        public CreateReaderPage(Library context)
        {
            InitializeComponent();
            Context = context;

            CreateReaderViewModel viewModel = new CreateReaderViewModel(new ReaderRepository(Context));
            Submit.Command = viewModel.CreateReaderCommand;

            DataContext = viewModel;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
