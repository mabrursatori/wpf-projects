using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsloadParse
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            LoadConfigAPi();

        }
        private const string filename = "ConfigAPI.xml";


        private void LoadConfigAPi()
        {

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("ConfigAPI.xml");
            XmlTextReader reader = null;



            foreach (XmlNode node in xmldoc)
            {
                //node.SelectSingleNode("detail").InnerText;
                dataGridView1.Rows.Add(xmldoc);
            }

            try
            {
                reader = new XmlTextReader(filename);
                reader.WhitespaceHandling = WhitespaceHandling.None;

                string name = "";
                string value = "";
                int cnt = 0;
                while (reader.Read())
                {
                    dataGridView1.Rows.Add();

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            dataGridView1.Rows.Add(reader.Name);
                            //name = reader.Name;
                            //dataGridView1.Rows[cnt].Cells[0].Value = reader.Name;
                            break;
                        //case XmlNodeType.Text:
                        //    dataGridView1.Rows.Add(reader.Value);
                        //    //value = reader.Value;
                        //    //dataGridView1.Rows[cnt].Cells[1].Value = reader.Value;
                        //    break;
                        case XmlNodeType.EndElement:
                            break;

                    }


                    //dataGridView1.Rows[cnt].Cells[0].Value = "1";
                    //dataGridView1.Rows[cnt].Cells[1].Value = "2";

                    //cnt++;
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

            }
        }
    
            private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string xmlFilePath = openFileDialog.FileName;
            //    using (DataSet ds = new DataSet())
            //    {
            //        ds.ReadXml(xmlFilePath);
            //        dataGridView1.DataSource = ds.Tables[0];
            //    }
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //XmlDocument xmldoc = new XmlDocument();
            //xmldoc.Load("ConfigAPI.xml");

            //XmlNodeList nodea = xmldoc.SelectNodes("/Table1");



            //foreach (XmlNode node in nodea)
            //{
            //    XmlNode titlenode = node.SelectSingleNode("ConfigAPI").InnerText;
            //}



            //ds.Tables.Add(dt);
            //ds.WriteXml(path);
            //dataGridView1.DataSource = dt;
        }
    }
}
