using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementObjectCollection collection;
            using (var finddevice = new ManagementObjectSearcher(@"Select * from Win32_USBHub"))
                collection = finddevice.Get();
            foreach(var device in collection)
            {
                checkedListBox1.Items.Add(device.GetPropertyValue("DeviceID"));
                checkedListBox1.Items.Add(device.GetPropertyValue("Description"));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemCheckState(i, (checkAll.Checked ? CheckState.Checked : CheckState.Unchecked));
        }
    }
}
