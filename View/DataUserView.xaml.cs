using Kørselslog.Repos;
using System.Windows.Controls;

namespace Kørselslog.View
{
    public partial class DataUserView : UserControl
    {
        public DataUserView()
        {
            InitializeComponent();
            BindDataGridToApp.BindDatagrid(DGUserData, "SELECT Name, LastName FROM [User]");
        }
    }
}
