using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfApp4.Views;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Начальная страница.
            Page page = new AuthPage();
            MainFrame.Navigate(page);
            MainFrame.NavigationService.LoadCompleted += new LoadCompletedEventHandler(MainFrame_LoadCompleted);
        }

        /**
         * Возможна ли навигация назад
         */
        private bool CanGoBack =>
                // Блокируем навигацию на предыдущую страницу, если уже находимся на главной
                // Не позволяет вернуться на страницу авторизации
                MainFrame.CanGoBack && MainFrame.Content.GetType() != typeof(MainPage);

        /**
         * Обработка ивента навигации. Скрываем кнопку навигации, если вернуться назад невозможно.
         */
        private void MainFrame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            GoBackButton.Visibility = CanGoBack ? Visibility.Visible : Visibility.Hidden;
        }

        /**
         * Обработка ивента клика на кнопку возврата назад.
         */
        private void GoBackButton_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}
