using System.Windows;
using System.Data.SqlClient;
using Kørselslog.Model;
using System;

namespace Kørselslog.Repos
{
    internal class AddUserToDataBase
    {
        private readonly string _message = "Indtast venligst alle værdier";

        private static bool IsValid(User u)
        {
            if(u.UserName == string.Empty || u.Password == string.Empty || u.Name == string.Empty || u.LastName == string.Empty || u.Email == string.Empty)
                return false;
            else
                return true;
        }

        internal void AddUserToSqlDataBase(User user)
        {
            if (IsValid(user))
            {
                try
                {
                    ConnectionString connectionString = new();
                    SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                    sqlCon.Open();

                    SqlCommand insertNewUserData = new($"INSERT INTO [User] VALUES ('{user.UserName}', '{user.Password}', '{user.Name}', '{user.LastName}', '{user.Email}')", sqlCon);
                    insertNewUserData.ExecuteNonQuery();

                    MessageBox.Show("Bruger oprettet");

                    sqlCon.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
                MessageBox.Show(_message, "FEJL", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}