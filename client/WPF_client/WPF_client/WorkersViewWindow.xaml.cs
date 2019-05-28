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
using WPF_client.Viewers;

namespace WPF_client
{
    /// <summary>
    /// Interaction logic for WorkersViewWindow.xaml
    /// </summary>
    public partial class WorkersViewWindow : Window
    {
        public WorkersViewWindow()
        {
            InitializeComponent();
        }

        private void FillWithWorkers(int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                Label name = new Label();
                name.Content = "Worker" + (i + 1);

                Label age = new Label();
                age.Content = rnd.Next(18, 45);

                Button btn = new Button();
                btn.Height = 20;
                btn.Width = 50;
                btn.Margin = new Thickness(0, 20, 0, 0);
                btn.Content = "view";

                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"C:\Users\dmark\Desktop\test\test\wordpress-login-url-1.png"));
                img.Height = 100;
                img.Width = 80;

                this.wp_datas.Items.Add(new WorkerViewer(img, name, age, btn).main_sp);
            }

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            FillWithWorkers(1);
        }
    }
}
