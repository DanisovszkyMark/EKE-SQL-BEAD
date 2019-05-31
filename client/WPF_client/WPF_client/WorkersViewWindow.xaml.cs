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
            age.Content = record.Birt_day;

            Button btn = new Button();
            btn.Height = 20;
            btn.Width = 50;
            btn.Margin = new Thickness(0, 20, 0, 0);
            btn.Content = "view";

            Image img = new Image();
            img.Source = new BitmapImage(new Uri(@"D:\Egyetem\6. félév\SQL\EKE-SQL-BEAD\client\WPF_client\WPF_client\Images\login.png"));
            img.Height = 100;
            img.Width = 80;
            
            return new WorkerViewer(record.Id,img, name, age, btn);
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
            this.btn_remove.IsEnabled = false;
            this.btn_update.IsEnabled = false;
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

        private void img_refresh_MouseUp(object sender, MouseButtonEventArgs e)
        {
            FillDatas();
        }

        private void cb_autoRefresh_Checked(object sender, RoutedEventArgs e)
        {
            refreshTimer.Start();
        }

        private void cb_autoRefresh_Unchecked(object sender, RoutedEventArgs e)
        {
            refreshTimer.Stop();
        }

        private void img_refresh_MouseEnter(object sender, MouseEventArgs e)
        {
            this.img_refresh.Source = new BitmapImage(new Uri(@"D:\Egyetem\6. félév\SQL\EKE-SQL-BEAD\client\WPF_client\WPF_client\Images\refresh_onMouse.ico"));
        }

        private void img_refresh_MouseLeave(object sender, MouseEventArgs e)
        {
            this.img_refresh.Source = new BitmapImage(new Uri(@"D:\Egyetem\6. félév\SQL\EKE-SQL-BEAD\client\WPF_client\WPF_client\Images\refresh.png"));
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            int id = -1;
            for (int i = 0; i < workerViewers.Count; i++)
            {
                if (workerViewers[i].clicked)
                {
                    id = workerViewers[i].Id;
                    break;
                }
            }
            if (id >= 0)
            {
                ManageWorkerViewWindow v = new ManageWorkerViewWindow(id);
                v.Closed += AddWorker_Closed;
                v.Show();
            }
        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            int id = -1;
            for (int i = 0; i < workerViewers.Count; i++)
            {
                if (workerViewers[i].clicked)
                {
                    id = workerViewers[i].Id;
                    break;
                }
            }
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.btn_remove.IsEnabled = false;
                this.btn_update.IsEnabled = false;
                client.RemovePerson(id);
                FillDatas();
            }

        }
    }
}
