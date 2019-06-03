using Microsoft.Win32;
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
using WPF_client.ServiceReference;

namespace WPF_client
{
    /// <summary>
    /// Interaction logic for ManageWorkerViewWindow.xaml
    /// </summary>
    public partial class ManageWorkerViewWindow : Window
    {
        private ServiceClient client;
        private int id;
        private string token;

        public ManageWorkerViewWindow(string token, int id)
        {
            InitializeComponent();
            client = new ServiceClient();
            this.id = id;
            this.token = token;
            if (id >= 0) this.lbl_type.Content = "Modify";

            FillDatas();
        }

        private void FillDatas()
        {
            if (this.id != -1)
            {
                PersonRecord record = client.SelectPersonById(this.token, this.id);

                this.tb_name.Text = record.Name;
                this.tb_birth.Text = record.Birt_day.ToString();
                this.tb_job.Text = record.Job_id.ToString(); 
            }
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (this.id == -1)
            {
                PersonRecord insertThis = new PersonRecord();
                insertThis.Name = this.tb_name.Text;
                insertThis.Birt_day = DateTime.Parse(this.tb_birth.Text);
                insertThis.Job_id = int.Parse(this.tb_job.Text);

                client.InsertPerson(this.token, insertThis);
                this.Close();
            }
            else //upate id alapján
            {
                PersonRecord record = new PersonRecord();
                record.Id = this.id;
                record.Name = this.tb_name.Text;
                record.Birt_day = DateTime.Parse(this.tb_birth.Text);
                record.Job_id = int.Parse(this.tb_job.Text);

                client.UpdatePerson(this.token, record);
                this.Close();
            }
        }

        private void btn_change_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                BitmapImage newImage = new BitmapImage();
                newImage.BeginInit();
                newImage.UriSource = new Uri(ofd.FileName);
                newImage.EndInit();

                this.img_image.Source = newImage;
            }
        }
    }
}
