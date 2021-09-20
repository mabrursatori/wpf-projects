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





namespace LoopingInputTrueOrFalse
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection("Data Source=DEV-4\\SQLEXPRESS;Initial Catalog=CoreDBTest;Integrated Security=True");

        
        public Boolean ItExists(string NomorNasabah)
        {
            SqlCommand dbcmd = new SqlCommand();
            dbcmd.CommandText = @"Select NomorNasabah From tblPin where NomorNasabah = '" + textBox1.Text + "";
            dbcmd.Connection = con;
            con.Open();
            int matchesCount = int.Parse(dbcmd.ExecuteScalar().ToString());
            con.Close();
            return matchesCount != 0;
        }

        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select NomorNasabah From tblPin where NomorNasabah ='" + textBox1.Text + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("It Exist");
            }
            else
            {
                MessageBox.Show("Kode Kartu Tidak Terdaftar");
            }

        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            Class1 C_koneksi;

            C_koneksi = new Class1();

            SqlConnection db = new SqlConnection(C_koneksi.koneksi());
            db.Open();
            SqlCommand dbcmd = db.CreateCommand();
            string sql = " Select NomorNasabah From tblPin where NomorNasabah ='" + textBox1.Text + "' ",con;
            dbcmd.CommandText = sql;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, C_koneksi.koneksi());
            DataTable myDataset = new DataTable();
            sqlAdapter.Fill(myDataset);
            db.Close();
            if (myDataset.Rows.Count >= 1)
            {
                MessageBox.Show("It Exist");
            }
            else
            {
                MessageBox.Show("Kode Kartu Tidak Terdaftar");
            }

        }
        */
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
