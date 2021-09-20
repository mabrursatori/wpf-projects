using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StoryBoardDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
            //this.Title = "Storyboards Example";
            //StackPanel myStackPanel = new StackPanel();
            //myStackPanel.Margin = new Thickness(20);

            //Rectangle myRectangle = new Rectangle();
            //myRectangle.Name = "MyRectangle";

            //// Create a name scope for the page.
            //NameScope.SetNameScope(this, new NameScope());

            //this.RegisterName(myRectangle.Name, myRectangle);
            //myRectangle.Width = 100;
            //myRectangle.Height = 100;
            //SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Blue);
            //this.RegisterName("MySolidColorBrush", mySolidColorBrush);
            //myRectangle.Fill = mySolidColorBrush;

            //DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            //myDoubleAnimation.From = 100;
            //myDoubleAnimation.To = 200;
            //myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            //Storyboard.SetTargetName(myDoubleAnimation, myRectangle.Name);
            //Storyboard.SetTargetProperty(myDoubleAnimation,
            //    new PropertyPath(Rectangle.LayoutTransformProperty));

            //ColorAnimation myColorAnimation = new ColorAnimation();
            //myColorAnimation.From = Colors.Blue;
            //myColorAnimation.To = Colors.Red;
            //myColorAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            //Storyboard.SetTargetName(myColorAnimation, "MySolidColorBrush");
            //Storyboard.SetTargetProperty(myColorAnimation,
            //    new PropertyPath(SolidColorBrush.ColorProperty));
            //Storyboard myStoryboard = new Storyboard();
            //myStoryboard.Children.Add(myDoubleAnimation);
            //myStoryboard.Children.Add(myColorAnimation);

            //myRectangle.MouseEnter += delegate (object sender, MouseEventArgs e)
            //{
            //    myStoryboard.Begin(this);

            //};


            //myStackPanel.Children.Add(myRectangle);
            //this.Content = myStackPanel;

           
        }
        Canvas myCanvas = new Canvas() { Background = Brushes.White };
        DoubleAnimation doubleAnimation = new DoubleAnimation();
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Rectangle> list = new List<Rectangle>();
            list.Add(new Rectangle() { Fill = Brushes.Red, Width = 1024, Height = 1280, Opacity = 0 });
            list.Add(new Rectangle() { Fill = Brushes.Yellow, Width = 1024, Height = 1280, Opacity = 0 });
            list.Add(new Rectangle() { Fill = Brushes.Blue, Width = 1024, Height = 1280, Opacity = 0 });
            ///Canvas.SetLeft(myStack, -3072);
            while (true)
            {
                foreach (Rectangle rect in list)
                {
                    myCanvas.Children.Add(rect);
                    cc.Content = myCanvas;


                    doubleAnimation.From = 0;
                    doubleAnimation.To = 1;
                    doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
                    rect.BeginAnimation(Canvas.OpacityProperty, doubleAnimation);

                    await Task.Delay(5000);

                    doubleAnimation.From = 1;
                    doubleAnimation.To = 0;
                    doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
                    rect.BeginAnimation(Canvas.OpacityProperty, doubleAnimation);
                    await Task.Delay(5000);

                    myCanvas.Children.Clear();
                }
            }
           
           


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
