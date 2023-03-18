using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FDPP.fppDataSetTableAdapters;

namespace FDPP
{
    /// <summary>
    /// Логика взаимодействия для DelUser.xaml
    /// </summary>
    public partial class DelUser : Page
    {
        usersTableAdapter users = new usersTableAdapter();
        public DelUser()
        {
            InitializeComponent();
            UsersGrid.ItemsSource = users.GetData();
            IdComb.ItemsSource = users.GetData();
            IdComb.DisplayMemberPath = "id";

        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            int userDel = users.GetData()[IdComb.SelectedIndex].id;
            users.DeleteQuery(userDel);
            UsersGrid.ItemsSource = users.GetData();
            IdComb.ItemsSource = users.GetData();
        }
    }
}
