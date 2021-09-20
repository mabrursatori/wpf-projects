using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
             
            XmlDocument doc = new XmlDocument();
            doc.Load("ConfigAPI.xml");

            XmlTextReader reader = null;

            try
            {
                reader = new XmlTextReader(filename);
                reader.WhitespaceHandling = WhitespaceHandling.None;

                while (reader.Read())
                {
                    

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            dataGridView1.Rows.Add(reader.Name);
                            break;
                        case XmlNodeType.Text:
                            dataGridView1.Rows.Add(reader.Value);
                            break;
                        case XmlNodeType.ProcessingInstruction:
                            dataGridView1.Rows.Add("<?{0} {1}?>",reader.Name, reader.Value);
                            break;
                        
                    }
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialog.FileName;
                using (DataSet ds = new DataSet())
                {
                    ds.ReadXml(xmlFilePath);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
