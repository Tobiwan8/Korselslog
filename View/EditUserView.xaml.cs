using Kørselslog.Repos;
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
    }
}
