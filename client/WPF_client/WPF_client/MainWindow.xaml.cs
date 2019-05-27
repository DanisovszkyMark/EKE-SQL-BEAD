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
using System.Windows.Threading;
//Csak tesztelésre
using System.Configuration;

namespace WPF_client
{
    /// <summary>
    /// 3 másodpercig szimulált töltőképernyő után megnyílik a bejelentkező felület
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            Logger.Log("Új felhasználó.");

            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            LoginWindowView view = new LoginWindowView();
            view.Show();
            this.Close();
        }
    }
}
