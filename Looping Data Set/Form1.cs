using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping_Data_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

           

            dt.Columns.Add("Config API 1");
            dt.Columns.Add("Detail API 2");

            List<String> Konfig = new List<string> { "Core UI Address", "Core Apps Address", "CorePassbookPrinterAddress", "CorePrinterAddress" };
            List<String> Detail = new List<string> { "HTTP://Localhost:3233","Http://Localhost:3333",
            "Http://Localhost:3001","Http://Localhost:3002"};


            dt.Rows.Add(Konfig[0], Detail[0]);
            dt.Rows.Add(Konfig[1], Detail[1]);
            dt.Rows.Add(Konfig[2], Detail[2]);
            dt.Rows.Add(Konfig[3], Detail[3]);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
