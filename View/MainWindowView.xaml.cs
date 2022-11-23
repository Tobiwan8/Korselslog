using Kørselslog.Repos;
using System;
using System.Windows;
using System.Windows.Input;


namespace Kørselslog.View
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            BindDataGridToApp.BindDatagrid(DGUser);
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

        private void BtnUserAdministration_Click(object sender, RoutedEventArgs e)
        {
            Kørselslog.View.UserAdministrationView dashboard = new();
            dashboard.Show();
        }

        private void BtnCarAdministration_Click(object sender, RoutedEventArgs e)
        {
            Kørselslog.View.CarAdministrationView dashboard = new();
            dashboard.Show();
        }

        private void BtnData_Click(object sender, RoutedEventArgs e)
        {
            Kørselslog.View.KorselslogView dashboard = new();
            dashboard.Show();
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Kørselslog.View.LoginView dashboard = new();
            dashboard.Show();
            this.Close();
            Login.IsLoggedIn = false;
        }
    }
}