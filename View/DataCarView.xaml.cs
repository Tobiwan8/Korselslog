using Kørselslog.Repos;
using System.Windows.Controls;

namespace Kørselslog.View
{
    
    public partial class DataCarView : UserControl
    {
        public DataCarView()
        {
            InitializeComponent();
            BindDataGridToApp.BindDatagrid(DGCarData, "SELECT Nummerplade, Model FROM [Biler]");
        }
    }
}
