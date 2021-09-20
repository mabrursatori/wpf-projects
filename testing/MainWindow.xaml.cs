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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image k;
        double w;
        double h;
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            this.Background = Brushes.Blue;
            (sender as Button).Background = Brushes.Yellow;
            k = (sender as Button).Content as Image;
            (sender as Button).Content = "Mabrur";
            w = k.Width;
            h = k.Height;
            MessageBox.Show(w.ToString());
        }

        private void Button_KeyUp(object sender, KeyEventArgs e)
        {
            this.Background = Brushes.Green;
            (sender as Button).Background = Brushes.Black;
            Image kl = k;
            kl.Width = w;
            kl.Height = h;
            (sender as Button).Content = kl;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Button_LostMouseCapture(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Yellow;
        }

        private void Button_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Blue;
        }
    }
}
