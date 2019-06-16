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
    /// Interaction logic for AddParentControl.xaml
    /// </summary>
    public partial class AddParentControl : UserControl
    {
        private string token;

        public AddParentControl(string token)
        {
            InitializeComponent();

            this.token = token;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient client = new ServiceClient();
            ParentRecord record = new ParentRecord();
            record.Name = tb_name.Text;

            try
            {
                record.Birth_day = Convert.ToDateTime(tb_birth_day.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid date");
                return;
            }

            try
            {
                client.InsertParent(token, record);
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
