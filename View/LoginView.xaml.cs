using System;
using System.Windows;
using System.Windows.Input;
using System.Data;
using System.Data.SqlClient;

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

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string connectionString = @"Server = DESKTOP-RDJ3VF9; Initial Catalog = Korselslog; persist security info = true; User ID=sa; Password=funnyHAHA";
            SqlConnection sqlConnection = new(connectionString);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                string queryUser = "SELECT COUNT(1) FROM [User] WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmdUser = new(queryUser, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlCmdUser.Parameters.AddWithValue("@Username", txtUser.Text);
                sqlCmdUser.Parameters.AddWithValue("@Password", txtPass.Password);
                int count = Convert.ToInt32(sqlCmdUser.ExecuteScalar());

                string queryAdmin = "SELECT COUNT(1) FROM [Admin] WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmdAdmin = new(queryAdmin, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlCmdAdmin.Parameters.AddWithValue("@Username", txtUser.Text);
                sqlCmdAdmin.Parameters.AddWithValue("@Password", txtPass.Password);
                int count2 = Convert.ToInt32(sqlCmdAdmin.ExecuteScalar());

                if (count == 1)
                {
                    MainWindowView dashboard = new();
                    dashboard.Show();
                    this.Close();
                }
                else if (count2 == 1)
                {
                    //Skift ud med admin vindue
                    MainWindowView dashboard = new();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
