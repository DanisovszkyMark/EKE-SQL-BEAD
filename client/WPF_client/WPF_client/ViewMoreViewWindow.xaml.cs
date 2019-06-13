using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ViewMoreViewWindow.xaml
    /// </summary>
    public partial class ViewMoreViewWindow : Window
    {
        private string token;

        public ViewMoreViewWindow(string token)
        {
            InitializeComponent();
            this.token = token;

            btn_info_Click(null, null);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Button).Background = (Brush)Application.Current.FindResource("MoreViewBackBrush");
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Button).Background = (Brush)Application.Current.FindResource("LightBackgroundBrush");
        }

        private void btn_errorLog_Click(object sender, RoutedEventArgs e)
        {
            ErrorLogControl control = new ErrorLogControl();

            StreamReader sr = new StreamReader("log.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.Contains("[ERROR]")) control.rtb_log.AppendText(line + '\n');
            }
            sr.Close();

            this.sp_view.Children.Clear();
            this.sp_view.Children.Add(control);
        }

        private void btn_generate_Click(object sender, RoutedEventArgs e)
        {
            GenerateDataControl control = new GenerateDataControl();

            this.sp_view.Children.Clear();
            this.sp_view.Children.Add(control);
        }

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {
            InfoControl control = new InfoControl(this.token);

            this.sp_view.Children.Clear();
            this.sp_view.Children.Add(control);
        }

        private void btn_newJob_Click(object sender, RoutedEventArgs e)
        {
            AddJobControl control = new AddJobControl();

            this.sp_view.Children.Clear();
            this.sp_view.Children.Add(control);
        }

        private void btn_newParent_Click(object sender, RoutedEventArgs e)
        {
            AddParentControl control = new AddParentControl();

            this.sp_view.Children.Clear();
            this.sp_view.Children.Add(control);
        }

        private void btn_PersonParent_Click(object sender, RoutedEventArgs e)
        {
            PersonParentControl control = new PersonParentControl();

            this.sp_view.Children.Clear();
            this.sp_view.Children.Add(control);
        }
    }
}
