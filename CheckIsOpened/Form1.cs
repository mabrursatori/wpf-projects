using CheckIsOpened.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIsOpened
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.ProcessName))
                {
                    listBox1.Items.Add(p.ProcessName);
                    if (p.ProcessName == "notepad")
                    {
                        MessageBox.Show("Notepad Terbuka");
                        Application.Exit();
                        this.Close();
                    }
                }
            }



        }
    } 
}
