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
            Logger.Info("Bejelentkezési ablak megnyitása");
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            Logger.Info("Bejelentkezési kísérlet a következő adatokkal: " + tb_username.Text + " " + pb_password.Password);

            try
            {
                if (canLogin() && Login())
                {
                    Logger.Info("A szerver kapcsolat létrejött.");

                    Login();
                    Logger.Info(String.Format("Sikeres bejelentkezés ({0})", tb_username.Text));

                    WorkersViewWindow newWindow = new WorkersViewWindow(this.username);
                    newWindow.Show();
                    this.Close();
                }
                else
                {
                    Logger.Error("Sikertelen bejelentkezés. Helytelen adatok.");
                    MessageBox.Show("Wrong username or password or already logged!");
                }
            }
            catch (FaultException<ServiceData> sd)
            {
                Logger.Error("[Service] " + sd.Message);
                MessageBox.Show(sd.Message);
            }
            catch (Exception)
            {
                Logger.Error("Ismeretlen hiba történt.");
                MessageBox.Show("Unexpected error!");
            }
        }

        private void connectToServer()
        {
            //throw new ConnectionException();
        }

        //Ezt illő lenne a szerveren elvégezni
        private bool canLogin()
        {
            UserRecord user = new UserRecord();
            user.Username = this.tb_username.Text;
            user.Password = this.pb_password.Password;

            ServiceClient client = new ServiceClient();
            List<UserRecord> records = client.SelectAllUser().ToList();

            foreach (UserRecord u in records)
            {
                if (u.Username == user.Username && u.Password == user.Password && !u.Logged)
                {
                    this.username = u.Username;
                    return true;
                }
            }
            
            return false;
        }

        private bool Login()
        {
            
            ServiceClient client = new ServiceClient();
            try
            {
                client.Login(this.username);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
