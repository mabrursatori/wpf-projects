using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadConfigAPI();
        }

        private const string filename = "ConfigAPI.xml";

        private void loadConfigAPI()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConfigAPI.xml");
            XmlTextReader reader = null;
            
            foreach(XmlNode node in doc.DocumentElement)
            {
                
                dataGridView1.Rows.Add(reader.Value);
            }
        }
    }
}
