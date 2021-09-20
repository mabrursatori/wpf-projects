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
using System.IO;
using System.Reflection;
using SetConfig.shared;
using Newtonsoft.Json;
using SetConfig.models;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace SetConfig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string testDir, readText;
        ConfigSetting config;
        ObservableCollection<String> items = new ObservableCollection<String>();

        private void SetConfig_Click(object sender, RoutedEventArgs e)
        {
            if (deviceId.Text != "")
                config.DeviceId = deviceId.Text;
            if (ipServer.Text != "")
                config.IpServer = ipServer.Text;
            if (portServer.Text != "")
                config.PortServer = portServer.Text;
            string json = JsonConvert.SerializeObject(config);
            items.Clear();
            Dictionary<string, dynamic> response = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            foreach (var item in response)
            {
                items.Add($"{ item.Key} : {item.Value}");
            }
            listBox.ItemsSource = items;
            File.WriteAllText(StringLib.path, json);
            MessageBox.Show("Berhasil Update","", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        public MainWindow()
        {
            InitializeComponent();
            this.testDir = StringLib.path;
            this.readText = File.ReadAllText(StringLib.path);
            this.config = JsonConvert.DeserializeObject<ConfigSetting>(readText);
            deviceId.Text = config.DeviceId;
            ipServer.Text = config.IpServer;
            portServer.Text = config.PortServer;
            Dictionary<string, dynamic> response = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(readText);
            foreach(var item in response)
            {
                items.Add($"{ item.Key} : {item.Value}");
            }
            listBox.ItemsSource = items;
        }
    }
}
