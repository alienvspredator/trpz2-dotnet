using System.Windows.Controls;
using System.Windows.Input;
using WpfApp4.Models;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        public BookPage(Book book)
        {
            InitializeComponent();

        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListViewItem listViewItem = sender as ListViewItem;
            object content = listViewItem.Content;
            //if (content is Author author)
            //{
            //    Page readerPage = new AuthorPage(author);
            //    NavigationService.Navigate(readerPage);
            //    return;
            //} else if (content is HistoryItem historyItem)
            //{
            //    Reader reader = historyItem.Reader;
            //    Page readerPage = new ReaderPage(reader);
            //    NavigationService.Navigate(readerPage);
            //    return;
            //}
        }
    }
}
