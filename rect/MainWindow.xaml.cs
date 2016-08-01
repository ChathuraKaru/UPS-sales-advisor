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
using System.Windows.Media.Animation;


namespace rect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private cus customerDetailEntry;
        private sales salesEntry;
        private ups upsConf;
        private Control currentVw;
        public MainWindow()
        {
            InitializeComponent();
            customerDetailEntry = new cus();
            salesEntry = new sales();
            upsConf = new ups();

            currentVw = upsConf;

            var bc = new BrushConverter();
            SwitchGrid.Background = (Brush)bc.ConvertFrom("#ffffff");
            winName.Content = "Ups Configuration";
            SwitchPane.Children.Add(currentVw);

        }

        public void SetWinName(String name){
            winName.Content = name;
        }

        //private void open_Click_1(object sender, RoutedEventArgs e)
        //{
        //    Storyboard sb = (Storyboard)TryFindResource("ol");
        //    sb.Begin();
        //}

        //private void close_Click_1(object sender, RoutedEventArgs e)
        //{
        //    Storyboard sb = (Storyboard)TryFindResource("cl");
        //    sb.Begin();

        //}

        private void tgbtn_Checked_1(object sender, RoutedEventArgs e)
        {
            splt.Visibility = Visibility.Collapsed;
        }

        private void tgbtn_Unchecked_1(object sender, RoutedEventArgs e)
        {
            splt.Visibility = Visibility.Visible;
        }

        private void salesRecord_Click_1(object sender, RoutedEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Sales Record Details";
            currentVw = salesEntry;
            SwitchPane.Children.Add(currentVw);
            var bc = new BrushConverter();
            SwitchGrid.Background = (Brush)bc.ConvertFrom("#e7ecef");
        }

        private void cusRecord_Click_1(object sender, RoutedEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Customer Record Details";
            currentVw = customerDetailEntry;
            SwitchPane.Children.Add(currentVw);
            var bc = new BrushConverter();
            SwitchGrid.Background = (Brush)bc.ConvertFrom("#e7ecef");

        }

        private void upsConfig_Click_1(object sender, RoutedEventArgs e)
        {
            SwitchPane.Children.Clear();
            winName.Content = "Ups Configuration";
            currentVw = upsConf;
            SwitchPane.Children.Add(currentVw);
            var bc = new BrushConverter();
            SwitchGrid.Background = (Brush)bc.ConvertFrom("#e7ecef");
        }

        private void SwitchPane_FocusableChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void SwitchPane_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            splt.Visibility = Visibility.Collapsed;
        }

        private void SwitchGrid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            splt.Visibility = Visibility.Collapsed;
        }

    }
}
