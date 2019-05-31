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
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public StackPanel main_sp;

        public bool clicked = false;

        private void Main_sp_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if(!clicked) main_sp.Background = (SolidColorBrush)Application.Current.FindResource("DefaultHighlightingBrush");
        }

        private void Main_sp_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            main_sp.Background = (SolidColorBrush)Application.Current.FindResource("HightlighterBrush");
        }

        private void Main_sp_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!clicked)
            {
                main_sp.Background = (SolidColorBrush)Application.Current.FindResource("HightlighterBrush");
                clicked = true;
            }
            else
            {
                main_sp.Background = (SolidColorBrush)Application.Current.FindResource("DefaultHighlightingBrush");
                clicked = false;
            }
        }

        public WorkerViewer(int id, Image image, Label lbl_name, Label lbl_age, Button btn_view)
        {
            this.Id = id;

            main_sp = new StackPanel();
            main_sp.Orientation = Orientation.Horizontal;
            main_sp.MouseEnter += Main_sp_MouseEnter;
            main_sp.MouseLeave += Main_sp_MouseLeave;
            main_sp.MouseUp += Main_sp_MouseUp;

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
            main_sp.Background = (SolidColorBrush)Application.Current.FindResource("DefaultHighlightingBrush");
        }
    }
}
