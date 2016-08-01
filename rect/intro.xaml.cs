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
    /// Interaction logic for intro.xaml
    /// </summary>
    public partial class intro : Window
    {
        public intro()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text == "" && pass.Password == "") {
                lblNot.Visibility= Visibility.Visible;
                lblNot.Content = "You haven't entered the username or password";
            }
            else{
                if (txtUser.Text == "admin") {
                    Admin ad = new Admin();
                    ad.Show();
                    this.Close();
                }
                else if(txtUser.Text == "accountant"){
                    Accountant ac = new Accountant();
                    ac.Show();
                    this.Close();
                }
                else if (txtUser.Text == "sales")
                {
                    mainUI nw = new mainUI();
                    nw.Show();
                    this.Close();
                }
                else {
                    lblNot.Visibility = Visibility.Visible;
                    lblNot.Content = "Incorrect user name or password";
                }
            }
        }

    }
}
