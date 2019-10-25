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
