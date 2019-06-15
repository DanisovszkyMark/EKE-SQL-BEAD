using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using WPF_client.Exceptions;
using WPF_client.ServiceReference;

namespace WPF_client
{
    /// <summary>
    /// A bejelentkezést teszi lehetővé.
    /// A bejelentkezési adatok ellenőrzéséhez MSSQL szerverhez csatlakozik.
    /// </summary>
    public partial class LoginWindowView : Window
    {
        private string username;

        public LoginWindowView()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            this.username = this.tb_username.Text;
            Logger.Info("login attempt. Username : " + tb_username.Text + " " + pb_password.Password);

            try
            {
                if (canLogin() && Login())
                {
                    Logger.Info("the server connection has been established.");

                    Login();
                    Logger.Info(String.Format("Login successful ({0})", tb_username.Text));

                    WorkersViewWindow newWindow = new WorkersViewWindow(this.username);
                    newWindow.Show();
                    this.Close();
                }
                else
                {
                    Logger.Error("Login failed");
                    MessageBox.Show("Login failed");
                }
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

        private void connectToServer()
        {
            //throw new ConnectionException();
        }

        private bool canLogin()
        {
            ServiceClient client = new ServiceClient();
            return client.CanLogin(this.tb_username.Text, Encryption.StringToMD5(this.pb_password.Password));
        }

        private bool Login()
        {
            
            ServiceClient client = new ServiceClient();
            try
            {
                client.Login(this.tb_username.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
