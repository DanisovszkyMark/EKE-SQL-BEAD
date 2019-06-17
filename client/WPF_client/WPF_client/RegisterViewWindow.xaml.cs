using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WPF_client.ServiceReference;

namespace WPF_client
{
    /// <summary>
    /// Interaction logic for RegisterViewWindow.xaml
    /// </summary>
    public partial class RegisterViewWindow : Window
    {
        public RegisterViewWindow()
        {
            InitializeComponent();
        }

        private void cb_show_password_Checked(object sender, RoutedEventArgs e)
        {
            this.pb_password.Visibility = Visibility.Collapsed;
            this.tb_password.Visibility = Visibility.Visible;
            this.tb_password.Text = this.pb_password.Password;

            this.pb_passwordAgain.Visibility = Visibility.Collapsed;
            this.tb_passwordAgain.Visibility = Visibility.Visible;
            this.tb_passwordAgain.Text = this.pb_passwordAgain.Password;
        }

        private void cb_show_password_Unchecked(object sender, RoutedEventArgs e)
        {
            this.pb_password.Visibility = Visibility.Visible;
            this.tb_password.Visibility = Visibility.Collapsed;
            this.pb_password.Password = this.tb_password.Text;

            this.pb_passwordAgain.Visibility = Visibility.Visible;
            this.tb_passwordAgain.Visibility = Visibility.Collapsed;
            this.pb_passwordAgain.Password = this.tb_passwordAgain.Text;
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (CheckPasswords())
            {
                try
                {
                    MessageBox.Show("Success!");
                    ServiceClient client = new ServiceClient();
                    UserRecord record = new UserRecord();
                    record.Username = this.tb_username.Text;
                    record.Password = Encryption.StringToMD5(this.cb_show_password.IsChecked == true ? this.tb_password.Text : this.pb_password.Password);
                    client.InsertUser(record);
                    this.Close();
                }
                catch (FaultException<ServiceData> sd)
                {
                    Logger.Error("[Service] " + sd.Message);
                    MessageBox.Show(sd.Message);
                }
                catch (Exception)
                {
                    Logger.Error("Error with Windows Service communication!");
                    MessageBox.Show("Error with Windows Service communication!");
                }
            }
            else MessageBox.Show("The passwords do not match!");
        }

        private bool CheckPasswords()
        {
            string pass = this.cb_show_password.IsChecked == true? this.tb_password.Text : this.pb_password.Password;
            string passAgain = this.cb_show_password.IsChecked == true ? this.tb_passwordAgain.Text : this.pb_passwordAgain.Password;

            return pass == passAgain ? true : false;
        }
    }
}
