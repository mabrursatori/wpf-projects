using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=localhost\\sqlexpress;Initial Catalog = CoreDBTest; Integrated Security = True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) ;
            {
                string q = " Insert Into Test(ID,Name) Values('" + textBox1.Text.ToString() + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                MessageBox.Show("Connection Success");
            }
        }
    }
}
