using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Core.Service;
using WpfApp4.Models;
using WpfApp4.ViewModels;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для BooksListPage.xaml
    /// </summary>
    public partial class BooksListPage : Page
    {
        private Library context;

        public BooksListPage()
        {
            InitializeComponent();
            context = DbConnectionService.GetConnection();
            DataContext = new BookListViewModel(new BookRepository(context));
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Book book = GetSelectedBook();
            if (book == null)
            {
                return;
            }

            Page bookPage = new BookPage(book);
            NavigationService.Navigate(bookPage);
        }

        private Book GetSelectedBook()
        {
            return (DataContext as BookListViewModel).SelectedBook;
        }

        private void CreateBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateBookPage(context));
        }

        private void RemoveBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = GetSelectedBook();
            if (book == null)
            {
                return;
            }

            NavigationService.Navigate(new CreateBookPage(book, context));
        }
    }
}
