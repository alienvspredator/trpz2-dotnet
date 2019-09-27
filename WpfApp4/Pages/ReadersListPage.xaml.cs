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
    /// Логика взаимодействия для ReadersListPage.xaml
    /// </summary>
    public partial class ReadersListPage : Page
    {
        public ReadersListPage()
        {
            List<Reader> readersList = new List<Reader>
            {
                new Reader("Danylo", "Shevchenko"),
                new Reader("Visual", "Studio"),
                new Reader("C", "Sharp"),
                new Reader("TR", "PZ"),
                new Reader("Foo", "Bar"),
                new Reader("Apple", "Pen"),
                new Reader("Pineapple", "Pen"),
                new Reader("Carl", "Johnson"),
                new Reader("Big", "Smoke")
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
    }
}
