using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\ConfigAPI.xml");
            dt.Columns.Add("Detail");
            dt.Columns.Add("Detail 2");

            //dt.Rows.Add("1", "2");
           
            XmlNodeList RootNodeList = doc.DocumentElement.SelectNodes("/ConfigAPI");
            //for (int i = 0; i < 2; i++)
            //{
            //    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());


            //}
            foreach (XmlNode ConfigNode in RootNodeList[0])
            {

                foreach (XmlNode childNode in ConfigNode.ChildNodes)
                {
                    dt.Rows.Add(childNode.ParentNode.Name, childNode.InnerText);
                    //int newRowIndex = dataGridView1.Rows.Add();
                    //dataGridView1.Rows[newRowIndex].Cells[0].Value = childNode.ParentNode.Name;
                    //dataGridView1.Rows[newRowIndex].Cells[0].ReadOnly = true;
                    //dataGridView1.Rows[newRowIndex].Cells[1].Value = childNode.InnerText;
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.Tables[0].WriteXml(sfd.FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReader xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                    ds.ReadXml(xmlFile);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}