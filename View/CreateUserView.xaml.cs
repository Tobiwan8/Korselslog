using System.Windows;
using System.Windows.Controls;
using Kørselslog.Repos;

namespace Kørselslog.View
{
    public partial class CreateUserView : UserControl
    {
        public CreateUserView()
        {
            InitializeComponent();
        }

        private void BtnUserCreateFinal_Click(object sender, RoutedEventArgs e)
        {
            AddUserToDataBase addUserToDataBase = new();
            addUserToDataBase.AddUserToSqlDataBase(TBUserName.Text, DBPassword.Text, TBFirstName.Text, TBLastName.Text, DBEmail.Text);
        }
    }
}
