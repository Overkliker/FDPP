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
    /// Логика взаимодействия для DelChat.xaml
    /// </summary>
    public partial class DelChat : Page
    {
        chatsTableAdapter chats = new chatsTableAdapter();
        public DelChat()
        {
            InitializeComponent();
            ChatsGrid.ItemsSource = chats.GetData();
            IdComb.ItemsSource = chats.GetData();
            IdComb.DisplayMemberPath = "id";
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            int userDel = chats.GetData()[IdComb.SelectedIndex].id;
            chats.DeleteQuery(userDel);
            ChatsGrid.ItemsSource = chats.GetData();
            IdComb.ItemsSource = chats.GetData();
        }
    }
}
