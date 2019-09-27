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
using WpfApp4.Core;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        public BookPage(Book book)
        {
            InitializeComponent();
            DataContext = this;
            List<Book> books = new List<Book>
            {
                new Book("Над кукушкиным гнездом."),
                new Book("Сияние")
            };

            lvAuthors.ItemsSource = new List<Author>
            {
                new Author("Sherlock", "Holmes", books)
            };

            Book = book;
            List<HistoryItem> history = new List<HistoryItem>()
            {
                new HistoryItem(Book, new Reader("Darth", "Vader"), "2019-09-22", "2019-11-22", "Н/Д", "У читателя"),
                new HistoryItem(Book, new Reader("Scooby", "Doo"), "2019-07-18", "2019-08-23", "2019-08-23", "Возвращена")
            };

            lvHistory.ItemsSource = history;
        }

        public Book Book;

        public string DisplayedBookPopularity { get => "Высокая"; }

        public string DisplayedBookStatus { get => "У читателя"; }
        public string DisplayedBookName { get => Book.Name; }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListViewItem listViewItem = sender as ListViewItem;
            object content = listViewItem.Content;
            if (content is Author author)
            {
                Page readerPage = new AuthorPage(author);
                NavigationService.Navigate(readerPage);
                return;
            } else if (content is HistoryItem historyItem)
            {
                Reader reader = historyItem.Reader;
                Page readerPage = new ReaderPage(reader);
                NavigationService.Navigate(readerPage);
                return;
            }
        }
    }
}
