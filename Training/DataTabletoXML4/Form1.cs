using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTabletoXML4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Company";
            dt.Columns.Add("Title");
            dt.Columns.Add("Commentary");
            dt.Columns.Add("Worker1");
            dt.Columns.Add("Worker2");
            ds.Tables.Add(dt);

            DataTable dt1 = new DataTable();
            dt1.TableName = "job Details";
            dt1.Columns.Add("JobList");
            dt1.Columns.Add("Detail");
            dt1.Columns.Add("JobExpalained");
            ds.Tables.Add(dt1);

            DataRow row = ds.Tables["Company"].NewRow();
            row["Title"] = textBox1.Text;
            row["Commentary"] = textBox2.Text;
            row["Worker1"] = textBox3.Text;
            row["Worker2"] = textBox2.Text;
            ds.Tables["Company"].Rows.Add(row);

            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row1 = ds.Tables["Job Details"].NewRow();
                row1["Title"]      = r.Cells[0].Value.ToString();
                row1["Commentary"] = r.Cells[1].Value.ToString();
                row1["Worker1"]    = r.Cells[2].Value.ToString();
                ds.Tables["Job Details"].Rows.Add(row1);
            }
            

            ds.WriteXml("C:\\ConfigAPI.xml");

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox5.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox6.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox7.Text;
        }
    }
}
