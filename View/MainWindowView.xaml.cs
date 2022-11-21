using System;
using System.Windows;
using System.Windows.Input;


namespace Kørselslog.View
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            Repos.BindDataGridToApp bindDG = new();
            bindDG.BindDatagrid(DGUser);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}