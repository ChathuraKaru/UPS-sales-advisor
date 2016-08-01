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
    /// Interaction logic for mainUI.xaml
    /// </summary>
    public partial class mainUI : Window
    {
        private cus customerDetailEntry;
        private sales salesEntry;
        private ups upsConf;
        private viewUps vwUps;
        private Control currentVw;
        public mainUI()
        {
            InitializeComponent();
            customerDetailEntry = new cus();
            salesEntry = new sales();
            upsConf = new ups();
            vwUps = new viewUps();

            currentVw = upsConf;

            winName.Content = "Ups Configuration";
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

        private void lblSales_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Sales Record Details";
            currentVw = salesEntry;
            SwitchPane.Children.Add(currentVw);
        }

        private void lblCus_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Customer Record Details";
            currentVw = customerDetailEntry;
            SwitchPane.Children.Add(currentVw);

        }

        private void lblUps_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Ups Configuration";
            currentVw = upsConf;
            SwitchPane.Children.Add(currentVw);
        }

        public void viewUps() {
            SwitchPane.Children.Clear();
            winName.Content = " View Ups Configuration";
            currentVw = vwUps;
            SwitchPane.Children.Add(currentVw);
        }

    }
}
