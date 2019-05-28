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
using WPF_client.Exceptions;

namespace WPF_client
{
    /// <summary>
    /// A bejelentkezést teszi lehetővé.
    /// A bejelentkezési adatok ellenőrzéséhez MSSQL szerverhez csatlakozik.
    /// </summary>
    public partial class LoginWindowView : Window
    {
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
                connectToServer();
                Logger.Info("A szerver kapcsolat létrejött.");

                if (canLogin())
                {
                    Logger.Info(String.Format("Sikeres bejelentkezés ({0})", tb_username.Text));
                    //felületváltás és logolás
                }
                else
                {
                    Logger.Error("Sikertelen bejelentkezés. Helytelen adatok.");
                    //Hiba logolása, visszaüzenés
                }
            }
            catch (ConnectionException ce)
            {
                Logger.Error("Hiba a szerver kapcsolatban.");
                //Hiba logolása, visszaüzenés
            }
            catch (Exception exc)
            {
                Logger.Error("Ismeretlen hiba történt.");
                //Hiba logolása, visszaüzenés
            }
        }

        private void connectToServer()
        {
            throw new ConnectionException();
        }

        private bool canLogin()
        {
            return false;
        }
    }
}
