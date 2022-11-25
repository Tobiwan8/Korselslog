using Kørselslog.Repos;
using System.Windows.Controls;

namespace Kørselslog.View
{
    public partial class EditCarView : UserControl
    {
        public EditCarView()
        {
            InitializeComponent();
            BindDataGridToApp.BindDatagrid(DGCar, "SELECT * FROM [Biler]");
        }
    }
}
