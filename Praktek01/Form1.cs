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

namespace Praktek01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds01 = new DataSet();
        DataTable dt01 = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\ConfigAPI.xml");
            dt01.Columns.Add("Detail Node");
            dt01.Columns.Add("Detail Value");
            XmlNodeList NodeRoot = doc.DocumentElement.SelectNodes("/ConfigAPI");
            //int newRowIndex = dataGridView1.Rows.Add();

            //for (int i = 0; i < 2; i++)
            //{
            //    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            //}

            foreach (XmlNode ConfigNode in NodeRoot[0])
            {

                foreach (XmlNode childNode in ConfigNode.ChildNodes)
                {
                    dt01.Rows.Add(childNode.ParentNode.Name, childNode.InnerText);
                    
                    
                }
            }

            //dataGridView1.Rows[newRowIndex].Cells[0].ReadOnly = true;
            dataGridView1.DataSource = dt01;
        }
    }
}

