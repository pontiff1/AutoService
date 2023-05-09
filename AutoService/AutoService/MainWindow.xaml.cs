using System.Data.SQLite;
using System.Windows;


namespace AutoService
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Pages.PageAuth pageAuth = new Pages.PageAuth(mainFrame)
            {
                Width = Width,
                Height = Height,
                Title = "Авторизация"
            };
            mainFrame.Navigate(pageAuth);
        }
    }
}