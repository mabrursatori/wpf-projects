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
using System.Xml.Linq;

namespace XMLtoDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {



        }
        private void button2_Click_1(object sender, EventArgs e)
        {
           

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("ConfigAPI.xml");
            doc.SelectSingleNode("ConfigAPI.xml");
            //if (n! = null)
            //{
            //    var n = node.SelectSingleNode("ConfigAPI.xml").InnerText;
            //}


            //doc.Load("Latihan.xml");
            //var text = doc.SelectSingleNode("root/Latihan/text()").InnerText;
            //XmlNode root = doc.DocumentElement;
            //foreach(var Latihan in doc.Descendants("Root"))
            //{
            //    Latihan.Add(new XElement("Latihan"));
            //}

            foreach (XmlNode node in nodeList)
            {
                string innerText = node.SelectSingleNode("/ConfigAPI/CoreUIAddress").InnerText;
               
            }

            

        }
    }
}
