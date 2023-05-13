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
using EkzLavrov.Model;

namespace EkzLavrov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txb_Password.IsEnabled = false;
        }

        public static class Globals
        {
            public static int UserRole;
            public static User userinfo { get; set; }
        }

        private void btn_sign(object sender, RoutedEventArgs e)
        {
            var curentuser = AppData.db.User.FirstOrDefault(u => u.Login == txb_login.Text);
            if (curentuser != null)
            {
                Globals.userinfo = curentuser;
                Globals.UserRole = curentuser.RoleId;
                txb_Password.IsEnabled = true;
                signin.Visibility = Visibility.Hidden;
                signin1.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Неправильный логин");
            }

        }

        private void btn_sign1(object sender, RoutedEventArgs e)
        {
            var curentuser1 = AppData.db.User.FirstOrDefault(u => u.Login == txb_login.Text && u.Password == txb_Password.Text);
            if (curentuser1 != null)
            {
                Globals.userinfo = curentuser1;
                Globals.UserRole = curentuser1.RoleId;
                Second second = new Second();
                second.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль");
            }
        }
    }
}
