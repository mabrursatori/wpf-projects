using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormToForm
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DEV-4\SQLEXPRESS;Initial Catalog=CoreDBTest;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void NSB_Button_Click(object sender, EventArgs e)
        {
            Nasabah nasabah = new Nasabah();
            this.Hide();
            nasabah.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Username From tbl.Student username ="+textBox1.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count >= 1)
            {
                MessageBox.Show("Name ");
            }
        }
    }
}
