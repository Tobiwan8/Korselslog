using Kørselslog.Repos;
using System.Data;
using System.Windows.Controls;

namespace Kørselslog.View
{
    public partial class EditUserView : UserControl
    {
        public EditUserView()
        {
            InitializeComponent();
            BindDataGridToApp.BindDatagrid(DGUser, "SELECT UserId, UserName, Name, LastName, Email FROM [User]");
        }

        private void BtnEditUser_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void BtnDeleteUser_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)DGUser.SelectedItem;

            DeleteUserFromDataBase deleteUser = new();
            deleteUser.DeleteUser(row["UserId"]);

            BindDataGridToApp.BindDatagrid(DGUser, "SELECT UserId, UserName, Name, LastName, Email FROM [User]");
        }
    }
}
