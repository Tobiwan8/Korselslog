using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace Kørselslog.Repos
{
    internal class BindDataGridToApp
    {
        internal static void BindDatagrid(DataGrid dg, string sqlCommand)
        {
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCom = new(sqlCommand, sqlConnection);
            DataTable dt = new();

            sqlConnection.Open();

            SqlDataReader dr = sqlCom.ExecuteReader();
            dt.Load(dr);
            dg.ItemsSource = dt.DefaultView;

            sqlConnection.Close();
        }
    }
}