using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Kørselslog.Model;
using Kørselslog.Repos;

namespace Kørselslog.View
{
    public partial class CreateUserView : UserControl
    {
        public CreateUserView()
        {
            InitializeComponent();
        }

        private void DBFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBLastName.Focus();
            }
        }
        private void DBLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBUserName.Focus();
            }
        }
        private void DBUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBEmail.Focus();
            }
        }
        private void DBEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBPassword.Focus();
            }
        }
        private void DBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnUserCreateFinal_Click(sender, e);
            }
        }
        private void BtnUserCreateFinal_Click(object sender, RoutedEventArgs e)
        {
            //var person = new Person() { DBUserName.Text, DBPassword.Text, DBFirstName.Text, DBLastName.Text, DBEmail.Text }
            User user = new() { UserName = DBUserName.Text, Password = DBPassword.Text, Name = DBFirstName.Text, LastName = DBLastName.Text, Email = DBEmail.Text };
            //user.UserName = DBUserName.Text;
            //user.Password = DBPassword.Text;
            //user.Name = DBFirstName.Text;
            //user.LastName = DBLastName.Text;
            //user.Email = DBEmail.Text;

            AddUserToDataBase addUserToDataBase = new AddUserToDataBase();
            addUserToDataBase.AddUserToSqlDataBase(user);
            //MessageBox.Show(DBUserName.Text, "FEJL", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
