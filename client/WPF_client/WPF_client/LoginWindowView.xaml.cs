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
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connectToServer();

                if (canLogin())
                {
                    //felületváltás és logolás
                }
                else
                {
                    //Hiba logolása, visszaüzenés
                }
            }
            catch (ConnectionException ce)
            {
                //Hiba logolása, visszaüzenés
            }
            catch (Exception exc)
            {
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
