using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace Kørselslog.Repos
{
    internal class AddUserToDataBase
    {
        private string _message = "Indtast venligst alle værdier";
        private bool IsValid(string name, string lastname, string username, string email, string password)
        {
            if (name == string.Empty || lastname == string.Empty || username == string.Empty || email == string.Empty || password == string.Empty)
                return false;
            return true;
        }

        internal void AddUserToSqlDataBase(string username, string password, string name, string lastname, string email)
        {
            if (!IsValid(name, lastname, username, email, password))
            {
                MessageBox.Show(_message, "FEJL", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ConnectionString connectionString = new();
                SqlConnection sqlCon = new (connectionString.ConnectionToSql);
                sqlCon.Open();

                SqlCommand insertNewUserData = new($"INSERT INTO [User] VALUES ('{username}','{password}', '{name}', '{lastname}', '{email}')", sqlCon);
                insertNewUserData.ExecuteNonQuery();

                MessageBox.Show("Success");

                sqlCon.Close();
            }
        }
    }
}
