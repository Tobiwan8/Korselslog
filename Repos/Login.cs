using System;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace Kørselslog.Repos
{
    internal class Login
    {
        internal void LoginViaSql(string username, string password)
        {
            Repos.ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                string queryUser = "SELECT COUNT(1) FROM [User] WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmdUser = new(queryUser, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlCmdUser.Parameters.AddWithValue("@Username", username);
                sqlCmdUser.Parameters.AddWithValue("@Password", password);
                int count = Convert.ToInt32(sqlCmdUser.ExecuteScalar());

                string queryAdmin = "SELECT COUNT(1) FROM [Admin] WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmdAdmin = new(queryAdmin, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlCmdAdmin.Parameters.AddWithValue("@Username", username);
                sqlCmdAdmin.Parameters.AddWithValue("@Password", password);
                int count2 = Convert.ToInt32(sqlCmdAdmin.ExecuteScalar());

                if (count == 1)
                {
                    Kørselslog.View.MainWindowView dashboard = new(); //Skift ud med user vindue
                    dashboard.Show();
                    sqlConnection.Close();
                }
                else if (count2 == 1)
                {
                    Kørselslog.View.MainWindowView dashboard = new();
                    dashboard.Show();
                    sqlConnection.Close();
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
