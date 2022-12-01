using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Kørselslog.Model;
using Kørselslog.Repos;

namespace Kørselslog.View
{
    public partial class EditUserCompleteView : UserControl
    {
        public EditUserCompleteView()
        {
            InitializeComponent();
        }

        private void DBEditFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBEditLastName.Focus();
            }
        }
        private void DBEditLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBEditUserName.Focus();
            }
        }
        private void DBEditUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBEditEmail.Focus();
            }
        }
        private void DBEditEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DBEditPassword.Focus();
            }
        }
        private void DBEditPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnUserEditFinal_Click(sender, e);
            }
        }
        private void BtnUserEditFinal_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
