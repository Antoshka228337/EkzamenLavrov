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
using System.Windows.Shapes;

namespace EkzLavrov
{
    /// <summary>
    /// Interaction logic for Second.xaml
    /// </summary>
    public partial class Second : Window
    {
        public Second()
        {
            InitializeComponent();

            if(MainWindow.Globals.UserRole==1)
            {
                Zakaz.Visibility = Visibility.Visible;
                Mened.Visibility = Visibility.Hidden;
                Klad.Visibility = Visibility.Hidden;
                Direk.Visibility = Visibility.Hidden;
            }

            if(MainWindow.Globals.UserRole==2)
            {
                Zakaz.Visibility = Visibility.Hidden;
                Mened.Visibility = Visibility.Visible;
                Klad.Visibility = Visibility.Hidden;
                Direk.Visibility = Visibility.Hidden;
            }

            if (MainWindow.Globals.UserRole==3)
            {
                Zakaz.Visibility = Visibility.Hidden;
                Mened.Visibility = Visibility.Hidden;
                Klad.Visibility = Visibility.Visible;
                Direk.Visibility = Visibility.Hidden;
            }
            
            if (MainWindow.Globals.UserRole==4)
            {
                Zakaz.Visibility = Visibility.Hidden;
                Mened.Visibility = Visibility.Hidden;
                Klad.Visibility = Visibility.Hidden;
                Direk.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
