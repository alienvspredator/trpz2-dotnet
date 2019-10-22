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

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateBookPage.xaml
    /// </summary>
    public partial class CreateBookPage : Page
    {
        public CreateBookPage()
        {
            InitializeComponent();
        }

        private void CreateAuthor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateAuthorPage());
        }

        private void RemoveAuthor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddAuthorToBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
