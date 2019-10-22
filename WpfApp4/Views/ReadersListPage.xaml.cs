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
    /// Логика взаимодействия для ReadersListPage.xaml
    /// </summary>
    public partial class ReadersListPage : Page
    {
        public ReadersListPage()
        {
            List<Reader> readersList = new List<Reader>
            {
            };

            InitializeComponent();
            DataContext = this;
            lvReaders.ItemsSource = readersList;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Reader reader = ((ListViewItem)sender).Content as Reader;
            if (reader == null)
            {
                return;
            }

            Page readerPage = new ReaderPage(reader);
            NavigationService.Navigate(readerPage);
        }

        private void CreateReader_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateReaderPage());
        }

        private void RemoveReader_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
