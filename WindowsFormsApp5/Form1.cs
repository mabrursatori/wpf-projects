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
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadConfigAPI();
        }
        private const string filename = "ConfigAPI.xml";

        private void LoadConfigAPI()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConfigAPI.xml");
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");


            int cnt = 0;

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
                            //dataGridView1.Rows[cnt].Cells[1].Value = reader.Name;
                            dataGridView1.Rows.Add(reader.Name);
                            dataGridView1.ReadOnly = true;
                            break;
                        //case XmlNodeType.Text:
                        //    dataGridView1.Rows.Add(reader.Value);
                        //    //dataGridView1.Rows[cnt].Cells[0].Value = reader.Value;
                        //    break;
                        //case XmlNodeType.EndElement:
                        //    break;
                    }
                    cnt++;

                    /* Kode Hari Ini 
                    for(int i = dt.Columns.Count -1; i>= 0; i--)
                    {
                        if (dt.Rows[i][1] == DBNull.Value)
                        {
                            dt.Rows[i].Delete();
                        }
                    }
                    dt.AcceptChanges();

                     ------------------------- */
                   
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    string path = "D:\\ConfigAPI.xml";
            //    DataSet ds = new DataSet();
            //    DataTable dt = new DataTable();

            //    foreach(DataGridViewColumn col in dataGridView1.Columns)
            //    {
            //        dt.Columns.Add(col.DataPropertyName, col.ValueType);



            //    }

            //    foreach(DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        DataRow row1 = dt.NewRow();

            //        dt.Rows.Add(row1);

            //        //DataRow row1 = dt.NewRow();

            //        //for (int i = 0; i < dataGridView1.ColumnCount; i++)

            //        //    //if value exists add that value else add Null for that field

            //        //    row1[i] = (row.Cells[i].Value == null ? DBNull.Value : row.Cells[i].Value);

            //        //dt.Rows.Add(row1);
            //    }

            //    ds.Tables.Add(dt);
            //    ds.WriteXml(path);
            //    MessageBox.Show("Success");
            //    this.Close();
        }
    }
}
