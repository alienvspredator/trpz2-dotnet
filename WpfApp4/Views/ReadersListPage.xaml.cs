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
    /// Логика взаимодействия для ReadersListPage.xaml
    /// </summary>
    public partial class ReadersListPage : Page
    {
        private Library context;

        public ReadersListPage()
        {
            InitializeComponent();
            context = DbConnectionService.GetConnection();
            DataContext = new ReadersListViewModel(new ReaderRepository(context));
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Reader reader = GetSelectedReader();
            if (reader == null)
            {
                return;
            }

            Page readerPage = new ReaderPage(reader);
            NavigationService.Navigate(readerPage);
        }

        private Reader GetSelectedReader()
        {
            return (DataContext as ReadersListViewModel).SelectedReader;
        }

        private void CreateReader_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateReaderPage(context));
        }

        private void RemoveReader_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
