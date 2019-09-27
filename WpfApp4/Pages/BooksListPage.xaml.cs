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
    /// Логика взаимодействия для BooksListPage.xaml
    /// </summary>
    public partial class BooksListPage : Page
    {
        public BooksListPage()
        {
            InitializeComponent();
            DisplayedBooks = new List<Book>
            {
                new Book("Лазарь"),
                new Book("Автостопом по Галактике")
            };

            lvBools.ItemsSource = DisplayedBooks;
        }

        public List<Book> DisplayedBooks { get; set; }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Book book = ((ListViewItem)sender).Content as Book;
            if (book == null)
            {
                return;
            }

            Page bookPage = new BookPage(book);
            NavigationService.Navigate(bookPage);
        }
    }
}
