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
        public Readers()
        {
            List<Reader> readersList = new List<Reader>
            {
                new Reader("Danylo", "Shevchenko"),
                new Reader("C#", "Nice")
            };
            InitializeComponent();
            lvReaders.DataContext = this;
            lvReaders.ItemsSource = readersList;
        }
    }
}
