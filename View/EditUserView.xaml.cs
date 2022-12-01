﻿using System.Data;
using System.Windows;
using System.Windows.Controls;
using Kørselslog.Model;
using Kørselslog.Repos;

namespace Kørselslog.View
{
    public partial class EditUserView : UserControl
    {
        public EditUserView()
        {
            InitializeComponent();
            BindDataGridToApp.BindDatagrid(DGUser, "SELECT * FROM [User]");
        }

        private void BtnEditUser_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //DataRowView row = (DataRowView)DGUser.SelectedItem;

            //User user = new() { UserName = row["UserName"].ToString() , Password = row["Password"].ToString(), Name = row["Name"].ToString(), LastName = row["LastName"].ToString(), Email = row["Email"].ToString() };

            Window parentWindow = Application.Current.MainWindow;
            
            if(parentWindow != null)
            {
                this.Visibility = Visibility.Collapsed;
                (parentWindow as UserAdministrationView).EditUserComplete.Visibility = Visibility.Visible;
            }
        }

        private void BtnDeleteUser_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)DGUser.SelectedItem;

            DeleteUserFromDataBase.DeleteUser(row["UserId"]);

            BindDataGridToApp.BindDatagrid(DGUser, "SELECT UserId, UserName, Name, LastName, Email FROM [User]");
        }
    }
}
