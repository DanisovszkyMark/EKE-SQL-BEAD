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
    /// Interaction logic for InfoControl.xaml
    /// </summary>
    public partial class InfoControl : UserControl
    {
        string token;

        public InfoControl(string token)
        {
            InitializeComponent();
            this.token = token;

            FillDatas();
        }

        private void FillDatas()
        {
            ServiceClient client = new ServiceClient();
            List<PersonRecord> records = new List<PersonRecord>(); 

            try
            {
                records = client.SelectAllPerson(this.token).ToList();
            }
            catch (FaultException<ServiceData> sd)
            {
                Logger.Error("[Service] " + sd.Message);
                MessageBox.Show(sd.Message);
            }

            this.lbl_numOfWorkers.Content = records.Count;
            this.lbl_lowestSalary.Content = records.Min(x => x.Salary);
            this.lbl_hightestSalary.Content = records.Max(x => x.Salary);
            this.lbl_avgSalary.Content = String.Format("{0:F0}",records.Average(x => x.Salary));
        }
    }
}
