using System.Windows.Controls;
using System.Windows.Input;
using WpfApp4.Models;
using WpfApp4.ViewModels;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для ReaderPage.xaml
    /// </summary>
    public partial class ReaderPage : Page
    {
        public ReaderPage(Reader reader)
        {
            InitializeComponent();
            ReaderDetailsViewModel viewModel = new ReaderDetailsViewModel(reader);
            DataContext = viewModel;
        }

        public readonly Reader Reader;

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //HistoryItem historyItem = ((ListViewItem)sender).Content as HistoryItem;
            //if (historyItem == null)
            //{
            //    return;
            //}

            //Book book = historyItem.Book;
            //Page bookPage = new BookPage(book);
            //NavigationService.Navigate(bookPage);
        }
    }
}
