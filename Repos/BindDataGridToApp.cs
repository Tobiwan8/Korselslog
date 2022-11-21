using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace Kørselslog.Repos
{
    internal class BindDataGridToApp
    {
        internal static void BindDatagrid(DataGrid DGUser)
        {
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCommand = new("SELECT UserId, UserName, Name, LastName, Email FROM [User]", sqlConnection);
            DataTable dt = new();

            sqlConnection.Open();

            SqlDataReader dr = sqlCommand.ExecuteReader();
            dt.Load(dr);
            DGUser.ItemsSource = dt.DefaultView;

            sqlConnection.Close();
        }
    }
}