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

namespace WPF_client
{
    /// <summary>
    /// Interaction logic for ViewMoreViewWindow.xaml
    /// </summary>
    public partial class ViewMoreViewWindow : Window
    {
        public ViewMoreViewWindow()
        {
            InitializeComponent();
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
            this.sp_views.Children.Clear();

            Label lbl = new Label();
            lbl.Foreground = (Brush)Application.Current.FindResource("LightForegroundBrush");
            lbl.Content = "Error Log";
            lbl.FontSize = 30;
            lbl.Margin = new Thickness(0,20,0,10);
            lbl.VerticalAlignment = VerticalAlignment.Top;
            lbl.HorizontalAlignment = HorizontalAlignment.Center;

            RichTextBox rtb_log = new RichTextBox();
            rtb_log.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            rtb_log.Height = this.Height;
            rtb_log.IsReadOnly = true;
            this.sp_views.Children.Add(lbl);
            this.sp_views.Children.Add(rtb_log);

            List<string> logs = new List<string>();
            StreamReader sr = new StreamReader("log.txt");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.Contains("[ERROR]")) logs.Add(line);
            }
            sr.Close();

            for (int i = 0; i < logs.Count; i++)
            {
                rtb_log.AppendText(logs[i] + '\n');
            }
        }
    }
}
