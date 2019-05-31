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
using System.Windows.Threading;
using WPF_client.ServiceReference;
using WPF_client.Viewers;

namespace WPF_client
{
    /// <summary>
    /// Interaction logic for WorkersViewWindow.xaml
    /// </summary>
    public partial class WorkersViewWindow : Window
    {
        ServiceClient client;
        private List<WorkerViewer> workerViewers;

        private DateTime lastRefresh;
        private DispatcherTimer refreshTimer;

        public WorkersViewWindow()
        {
            InitializeComponent();
            client = new ServiceClient();
            workerViewers = new List<WorkerViewer>();

            lastRefresh = new DateTime();
            refreshTimer = new DispatcherTimer();
            refreshTimer.Interval = new TimeSpan(0, 0, 2);
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();

            FillDatas();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (client.NeedRefresh(lastRefresh))
            {
                FillDatas();
            }
        }

        private void FillDatas()
        {
            this.wp_datas.Items.Clear();
            workerViewers.Clear();

            List<PersonRecord> records = client.SelectAllPerson().ToList();

            for (int i = 0; i < records.Count; i++)
            {
                WorkerViewer v = PersonToViewer(records[i]);
                workerViewers.Add(v);
                this.wp_datas.Items.Add(workerViewers[i].main_sp);
            }

            lastRefresh = DateTime.Now;
        }

        private WorkerViewer PersonToViewer(PersonRecord record)
        {
            Label name = new Label();
            name.Content = record.Name;

            Label age = new Label();
            age.Content = DateTime.Now - record.Birt_day;

            Button btn = new Button();
            btn.Height = 20;
            btn.Width = 50;
            btn.Margin = new Thickness(0, 20, 0, 0);
            btn.Content = "view";

            Image img = new Image();
            img.Source = new BitmapImage(new Uri(@"D:\Egyetem\6. félév\SQL\EKE-SQL-BEAD\client\WPF_client\WPF_client\Images\login.png"));
            img.Height = 100;
            img.Width = 80;

            return new WorkerViewer(img, name, age, btn);
        }

        //tesztelésre
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
            ManageWorkerViewWindow addWorker = new ManageWorkerViewWindow(-1);
            addWorker.Closed += AddWorker_Closed;
            addWorker.Show();
        }

        private void AddWorker_Closed(object sender, EventArgs e)
        {
            FillDatas();
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            bool isActive = false;
            bool moreThanOne = false;

            for (int i = 0; i < workerViewers.Count; i++)
            {
                if (workerViewers[i].clicked)
                {
                    if (isActive)
                    {
                        moreThanOne = true;
                        break;
                    }

                    this.btn_remove.IsEnabled = true;
                    this.btn_update.IsEnabled = true;
                    isActive = true;
                }
            }

            if (!isActive || moreThanOne)
            {
                this.btn_remove.IsEnabled = false;
                this.btn_update.IsEnabled = false;
            }
        }
    }
}
