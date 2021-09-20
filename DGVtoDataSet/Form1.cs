using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGVtoDataSet
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
            ds.DataSetName = "Set Latihan 01";
            dt.TableName = "Contoh 01";
            dt.Columns.Add("No",typeof(int));
            dt.Columns.Add("Item Name", typeof(String));
            dt.Columns.Add("Detail", typeof(string));
            dataGridView1.DataSource = dt;
        }
    }
}
