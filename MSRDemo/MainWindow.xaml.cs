using System;
using System.Collections.Generic;
using System.IO.Ports;
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

namespace MSRDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
            mySerialPort.DataReceived += OnDataReceived;
            mySerialPort.Open();
            cc.Content = mySerialPort;



        }
        SerialPort mySerialPort = new SerialPort() { PortName = "COM7", BaudRate = 9600, Parity = Parity.None, DataBits = 8, StopBits = StopBits.One };

        private void OnDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            string k = (sender as SerialPort).ReadExisting();
            MessageBox.Show(k);
            mySerialPort.Close();
            mySerialPort.Open();
        }


    }
}
