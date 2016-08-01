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

namespace rect
{
    /// <summary>
    /// Interaction logic for ups.xaml
    /// </summary>
    public partial class ups : UserControl
    {
        private int compLoad = 20;
        private int CCTVLoad = 30;
        private int ACLoad = 40;
        public ups()
        {
            InitializeComponent();
        }

        private void btnCap_Click_1(object sender, RoutedEventArgs e)
        {
            String not = "";

            int pVal;
            if (txtCap.Text == "") {
                if (lblNotCap.Content.ToString() != "Not")
                {
                    not = lblNotCap.Content.ToString();
                }
                lblNotCap.Content = "";
                lblNotCap.Visibility = Visibility.Visible;
                lblNotCap.Content = not + "Invalid capacity.";
            }
            else if (int.TryParse(lblNotCap.Content.ToString(), out pVal))
            {
                lblNotCap.Content = "";
                lblNotCap.Visibility = Visibility.Visible;
                lblNotCap.Content = not + "Invalid input.";
            }
            if (cmbCap.SelectedItem == null) {
                not = lblNotCap.Content.ToString();
                lblNotCap.Content = "";
                lblNotCap.Visibility = Visibility.Visible;
                lblNotCap.Content = not + "Please specify units.";               
            }
        }

        private void btnPow_Click_1(object sender, RoutedEventArgs e)
        {
            lblNotPow.Visibility = Visibility.Visible;
            String not = "";
            lblNotPow.Content = "";
            int pVal;
            if (txtPow.Text == "")
            {
                if (lblNotPow.Content.ToString() != "Not")
                {
                    not = lblNotPow.Content.ToString();
                }
                lblNotPow.Content = not + "Invalid capacity.";
            }
            else if (!int.TryParse(lblNotPow.Content.ToString(), out pVal)) {
                lblNotPow.Content = not + "Invalid input.";
            }
            if (cmbPow.SelectedItem == null)
            {
                not = lblNotPow.Content.ToString();
                lblNotPow.Content = not + "Please specify units";
            }
        }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            int total = 0;
            if (lstDevice.SelectedItem == null)
            {
                MessageBox.Show("Please select a device");
            }
            else
            {
                String ip = ((ListBoxItem)lstDevice.SelectedItem).Content.ToString();
                lstDisplay.Items.Add(ip);
                lblLoad.Visibility = Visibility.Visible;
                if (ip.Equals("Computer")) {
                    if (lblLoad.Content.ToString() != "not")
                    {
                        total = int.Parse(lblLoad.Content.ToString());
                    }
                    total = total + compLoad;
                    lblLoad.Content = total.ToString();
                }
                if (ip.Equals("CCTV"))
                {
                    if (lblLoad.Content.ToString() != "not")
                    {
                        total = int.Parse(lblLoad.Content.ToString());
                    }
                    total = total + CCTVLoad;
                    lblLoad.Content = total.ToString();
                }
                if (ip.Equals("AC"))
                {
                    if (lblLoad.Content.ToString() != "not")
                    {
                        total = int.Parse(lblLoad.Content.ToString());
                    }
                    total = total + ACLoad;
                    lblLoad.Content = total.ToString();
                }

            }
        }

        private void btnFind_Click_1(object sender, RoutedEventArgs e)
        {
            if (lstDisplay.Items.Count == 0)
            {
                MessageBox.Show("Please add some devices");
            }
            else {
                mainUI prnt = (mainUI)Window.GetWindow(this);
                prnt.viewUps();

            }
        }

        private void btnClear_Click_1(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Clear();
            lblLoad.Content = "";
        }


    }
}
