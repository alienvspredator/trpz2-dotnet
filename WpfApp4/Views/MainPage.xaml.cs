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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Readers_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Page readersPage = new ReadersListPage();
            NavigationService.Navigate(readersPage);
        }
        private void Books_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Page booksPage = new BooksListPage();
            NavigationService.Navigate(booksPage);
        }
    }
}
