using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            

        }
        public static int index = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            string appName = Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule.ModuleName);
            
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.ProcessName) && p.ProcessName == appName)
                {
                    index++;
                    if(index > 1)
                    {
                        Application.Exit();
                    }
                    listBox1.Items.Add(p.ProcessName);
                    
                }
            }
        }
    }
}
