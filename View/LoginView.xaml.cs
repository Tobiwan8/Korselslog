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
using System.Windows.Shapes;
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

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Server = DESKTOP-RDJ3VF9; Initial Catalog = Korselslog; persist security info = true; User ID=sa; Password=funnyHAHA";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                if(sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                string query = "SELECT COUNT(1) FROM [User] WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlConnection);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", txtUser.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPass.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                
                if(count == 1)
                {
                    MainWindowView dashboard = new MainWindowView();
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
