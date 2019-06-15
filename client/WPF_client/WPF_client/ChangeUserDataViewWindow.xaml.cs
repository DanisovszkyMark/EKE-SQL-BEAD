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
    /// Interaction logic for ChangeUserDataViewWindow.xaml
    /// </summary>
    public partial class ChangeUserDataViewWindow : Window
    {
        private string token;
        private string username;

        public ChangeUserDataViewWindow(string token, ref string username)
        {
            InitializeComponent();

            this.token = token;
            this.username = username;
        }

        private void cb_show_password_Checked(object sender, RoutedEventArgs e)
        {
            this.pb_password.Visibility = Visibility.Collapsed;
            this.tb_password.Visibility = Visibility.Visible;
            this.tb_password.Text = this.pb_password.Password;

            this.pb_newPassword.Visibility = Visibility.Collapsed;
            this.tb_newPassword.Visibility = Visibility.Visible;
            this.tb_newPassword.Text = this.pb_newPassword.Password;
        }

        private void cb_show_password_Unchecked(object sender, RoutedEventArgs e)
        {
            this.pb_password.Visibility = Visibility.Visible;
            this.tb_password.Visibility = Visibility.Collapsed;
            this.pb_password.Password = this.tb_password.Text;

            this.pb_newPassword.Visibility = Visibility.Visible;
            this.tb_newPassword.Visibility = Visibility.Collapsed;
            this.pb_newPassword.Password = this.tb_newPassword.Text;
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient client = new ServiceClient();
            string password = this.cb_show_password.IsChecked == true ? this.tb_password.Text : this.pb_password.Password;
            string newPassword = this.cb_show_password.IsChecked == true ? this.tb_newPassword.Text : this.pb_newPassword.Password;

            try
            {
                client.UpdateUser(this.token, this.username, Encryption.StringToMD5(password), this.tb_username.Text, Encryption.StringToMD5(newPassword));
                this.username = this.tb_username.Text;
                MessageBox.Show("Success!");
            }
            catch (FaultException<ServiceData> sd)
            {
                Logger.Error("[Service] " + sd.Message);
                MessageBox.Show(sd.Message);
            }
        }
    }
}
