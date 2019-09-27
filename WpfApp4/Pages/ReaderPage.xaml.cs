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
    /// Логика взаимодействия для ReaderPage.xaml
    /// </summary>
    public partial class ReaderPage : Page
    {
        public ReaderPage(Reader reader)
        {
            InitializeComponent();
            DataContext = this;
            Reader = reader;
            List<HistoryItem> historyItems = new List<HistoryItem>()
            {
                new HistoryItem(new Book("How to learn C#"), Reader, "2019-09-22", "2019-11-22", "Н/Д", "У читателя"),
                new HistoryItem(new Book("C# Easy"), Reader, "2019-07-18", "2019-08-23", "2019-08-23", "Возвращена")
            };

            lvHistory.ItemsSource = historyItems;
        }

        public readonly Reader Reader;

        public string DisplayedProfileImage
        {
            get => Reader.ImageSource;
        }

        public string DisplayedProfileName
        {
            get => $"{Reader.Name} {Reader.Surname}";
        }

        public string DisplayedProfileReputation
        {
            get => "Хорошая";
        }

        public string DisplayedProfileHomeplace
        {
            get => "Политехничная, 41";
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            HistoryItem historyItem = ((ListViewItem)sender).Content as HistoryItem;
            if (historyItem == null)
            {
                return;
            }

            Book book = historyItem.Book;
            Page bookPage = new BookPage(book);
            NavigationService.Navigate(bookPage);
        }
    }
}
