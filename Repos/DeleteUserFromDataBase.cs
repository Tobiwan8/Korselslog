using System.Windows;
using System.Data.SqlClient;
using System;

namespace Kørselslog.Repos
{
    internal class DeleteUserFromDataBase
    {
        internal static void DeleteUser(object row)
        {
            try
            {
                ConnectionString connectionString = new();
                SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                sqlCon.Open();

                SqlCommand insertNewUserData = new($"DELETE FROM [User] WHERE UserId = {row}", sqlCon);
                insertNewUserData.ExecuteNonQuery();

                MessageBox.Show("Bruger slettet");

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
