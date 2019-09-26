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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Readers.xaml
    /// </summary>
    public partial class Readers : Page
    {
        public Readers(Page backPage)
        {
            InitializeComponent();
            BackPage = backPage;
            List<Reader> readersList = new List<Reader>();
            readersList.Add(new Reader("Danylo", "Shevchenko"));
            readersList.Add(new Reader("C#", "Govno"));
            lvReaders.ItemsSource = readersList;
        }

        private readonly Page BackPage;

        private void GoBack_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(BackPage);
        }
    }
}
