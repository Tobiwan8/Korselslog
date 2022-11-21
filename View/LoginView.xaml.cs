using System.Windows;
using System.Windows.Input;

namespace Kørselslog.View
{
    public partial class LoginView : Window
    {
        public LoginView()
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

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Repos.Login login = new();
                login.LoginViaSql(txtUser.Text, txtPass.Password);
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Repos.Login login = new();
            login.LoginViaSql(txtUser.Text, txtPass.Password);
        }
    }
}
