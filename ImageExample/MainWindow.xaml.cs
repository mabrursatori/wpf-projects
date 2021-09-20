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

namespace ImageExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Image newImage = new Image() {HorizontalAlignment = HorizontalAlignment.Stretch, Source = new BitmapImage(new Uri("https://www.publicdomainpictures.net/pictures/320000/velka/background-image.png")) };
            grid.Children.Add(newImage);
        }
    }
}
