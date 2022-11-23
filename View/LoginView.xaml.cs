using Kørselslog.Repos;
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
                Login.LoginViaSql(txtUser.Text, txtPass.Password);
            }
            if (Login.IsLoggedIn)
                this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login.LoginViaSql(txtUser.Text, txtPass.Password);
            if(Login.IsLoggedIn)
                this.Close();
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Bare ærgerligt, Sonny boy");
        }
    }
}
