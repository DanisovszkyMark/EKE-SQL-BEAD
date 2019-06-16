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
    /// Interaction logic for PersonParentControl.xaml
    /// </summary>
    public partial class PersonParentControl : UserControl
    {
        private string token;

        public PersonParentControl(string token)
        {
            InitializeComponent();

            this.token = token;

            FillDatas();
        }

        private void FillDatas()
        {
            ServiceClient client = new ServiceClient();
            List<PersonRecord> persons = new List<PersonRecord>();
            List<ParentRecord> parents = new List<ParentRecord>();
            try
            {
                persons = client.SelectAllPerson(token).ToList();
                parents = client.SelectAllParent(token).ToList();
            }
            catch (FaultException<ServiceData> sd)
            {
                Logger.Error("[Service] " + sd.Message);
                MessageBox.Show(sd.Message);
            }

            for (int i = 0; i < persons.Count; i++)
            {
                this.cb_person.Items.Add(persons[i].Name);
            }

            for (int i = 0; i < parents.Count; i++)
            {
                this.cb_parent.Items.Add(parents[i].Name);
            }
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient client = new ServiceClient();

            try
            {
                int person_id = client.SelectPersonId(this.token, this.cb_person.Text);
                int parent_id = client.SelectParentId(this.token, this.cb_parent.Text);

                client.InsertPersonParent(this.token, person_id, parent_id);
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
