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

        public ManageWorkerViewWindow(int id)
        {
            InitializeComponent();
            client = new ServiceClient();
            this.id = id;

            FillDatas();
        }

        private void FillDatas()
        {
            if (this.id != -1)
            {

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

                client.InsertPerson(insertThis);
                this.Close();
            }
            else //upate
            {

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
