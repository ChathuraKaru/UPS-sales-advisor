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

namespace rect
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        private MngUsers mngUsers;
        private MngUpsData upsData;
        private Control currentVw;
        public Admin()
        {
            InitializeComponent();
            upsData = new MngUpsData();
            mngUsers = new MngUsers();

            currentVw = mngUsers;

            winName.Content = "Manage User Details";
            SwitchPane.Children.Add(currentVw);
        }

        private void tgbtn_Checked_1(object sender, RoutedEventArgs e)
        {
            splt.Visibility = Visibility.Collapsed;
        }

        private void tgbtn_Unchecked_1(object sender, RoutedEventArgs e)
        {
            splt.Visibility = Visibility.Visible;
        }

        private void lblUsers_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Manage User Details";
            currentVw = mngUsers;
            SwitchPane.Children.Add(currentVw);
        }

        private void lblMngUps_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Manage Ups Details";
            currentVw = upsData;
            SwitchPane.Children.Add(currentVw);
        }
    }
}
