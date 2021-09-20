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

namespace row2ndtable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("pass");
            dt.Columns.Add("node");

            dt.Rows.Add(1, XmlNodeType.Text);
            dt.Rows.Add(2, XmlNodeType.Text);
            dt.Rows.Add(3, XmlNodeType.Text);
            dt.Rows.Add(4, XmlNodeType.Text);
            dt.Rows.Add(5, XmlNodeType.Text);

            DataSet dsload = new DataSet();

            dsload.ReadXml("ConfigAPI.xml");
            dataGridView1.DataSource = dt;
        }
    }
}
