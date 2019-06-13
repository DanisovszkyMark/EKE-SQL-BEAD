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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_client.ServiceReference;

namespace WPF_client
{
    /// <summary>
    /// Interaction logic for GenerateDataControl.xaml
    /// </summary>
    public partial class GenerateDataControl : UserControl
    {
        private ServiceClient client;
        public GenerateDataControl()
        {
            InitializeComponent();

            client = new ServiceClient();
        }

        private void btn_generate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Logger.Info("Generate persons");
                client.generatePersons(Convert.ToInt32(this.tb_numberOfRecords.Text), this.cb_dropFirst.IsChecked == true ? true : false);
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
