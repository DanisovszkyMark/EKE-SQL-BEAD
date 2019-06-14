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
    /// Interaction logic for AddJobControl.xaml
    /// </summary>
    public partial class AddJobControl : UserControl
    {
        private string token;

        public AddJobControl(string token)
        {
            InitializeComponent();
            this.token = token;
        }

        private void btn_addJob_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient client = new ServiceClient();

            try
            {
                client.InsertJob(this.token, this.tb_workplace.Text, this.tb_job.Text, this.tb_description.Text);
                MessageBox.Show("success!");
                ClearDatas();
            }
            catch (FaultException<ServiceData> sd)
            {
                Logger.Error("[Service] " + sd.Message);
                MessageBox.Show(sd.Message);
            }
        }

        private void ClearDatas()
        {
            this.tb_workplace.Text = "";
            this.tb_job.Text = "";
            this.tb_description.Text = "";
        }
    }
}
