using System;
using System.Windows;
using System.Windows.Input;
using System.Data;
using System.Data.SqlClient;


namespace Kørselslog.View
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            BindDatagrid();
        }

        private void BindDatagrid()
        {
            string connectionString = @"Server = DESKTOP-RDJ3VF9; Initial Catalog = Korselslog; persist security info = true; User ID=sa; Password=funnyHAHA";
            SqlConnection sqlConnection = new(connectionString);
            SqlCommand sqlCommand = new("SELECT UserId, UserName, Name, LastName, Email FROM [User]", sqlConnection);
            DataTable dt = new();

            sqlConnection.Open();

            SqlDataReader dr = sqlCommand.ExecuteReader();
            dt.Load(dr);
            DGUser.ItemsSource = dt.DefaultView;

            sqlConnection.Close();
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
    }
}
