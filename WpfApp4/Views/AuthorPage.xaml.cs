using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfApp4.Models;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        public AuthorPage(Author author)
        {
            InitializeComponent();
            DataContext = this;
            Author = author;
            //lvBools.ItemsSource = Author.Books;
        }

        public string DisplayedProfileName => "123"; // get => Author.Fullname;

        public List<Book> DisplayedBooks => new List<Book>(); /* get => Author.Books; */

        public Author Author { get; set; }

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
