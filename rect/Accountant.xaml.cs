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
    /// Interaction logic for Accountant.xaml
    /// </summary>
    public partial class Accountant : Window
    {
        private updatePrices upPrice;
        private SalesReport salRep;
        private Control currentVw;
        public Accountant()
        {
            InitializeComponent();
            upPrice = new updatePrices();
            salRep = new SalesReport();

            currentVw = upPrice;

            winName.Content = "Update Prices";
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

        private void lblPrices_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Update Prices";
            currentVw = upPrice;
            SwitchPane.Children.Add(currentVw);
        }

        private void lblReport_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Sales Reports";
            currentVw = salRep;
            SwitchPane.Children.Add(currentVw);
        }
    }
}
