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
            var viewModel = new ReaderDetailsViewModel(reader);
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
