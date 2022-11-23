using System.Windows;
using System.Windows.Input;

namespace Kørselslog.View
{
    public partial class CarAdministrationView : Window
    {
        public CarAdministrationView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Kørselslog.View.MainWindowView dashboard = new();
            dashboard.Show();
            this.Close();
        }
    }
}
