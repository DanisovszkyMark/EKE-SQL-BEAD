using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_client.Viewers
{
    public class WorkerViewer
    {
        public StackPanel main_sp;

        public WorkerViewer(Image image, Label lbl_name, Label lbl_age, Button btn_view)
        {
            main_sp = new StackPanel();
            main_sp.Orientation = Orientation.Horizontal;

            StackPanel image_sp = new StackPanel();
            image_sp.Children.Add(image);
            main_sp.Children.Add(image_sp);

            StackPanel datas_sp = new StackPanel();
            datas_sp.Orientation = Orientation.Vertical;
            datas_sp.Children.Add(lbl_name);
            datas_sp.Children.Add(lbl_age);
            datas_sp.Children.Add(btn_view);
            datas_sp.Width = 70;
            main_sp.Children.Add(datas_sp);

            main_sp.Margin = new Thickness(5, 5, 5, 5);
            main_sp.Background = new SolidColorBrush(Colors.Gray);
        }
    }
}
