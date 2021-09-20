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

namespace Work_Project
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEV-4\\SQLEXPRESS;Initial Catalog=CoreDBTest;Integrated Security=True"); 

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form_Nasabah nasabah = new Form_Nasabah();
            this.Hide();
            nasabah.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Non_Nasabah nonNasabah = new Form_Non_Nasabah();
            this.Hide();
            nonNasabah.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "Belajar Method";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Fungsi_Baca_KD kelas = new Fungsi_Baca_KD();
            //textBox1.Text = kelas.methodClass();

            //Save dan Cek Textbox apakah sudah ada di DB atau engga

            SqlDataAdapter da = new SqlDataAdapter("Select Name From TblNames2 where Name ='" + textBox1.Text + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("It Exist");
            }

            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TblNames2 (Name) Values('" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                MessageBox.Show("name Saved");
            }
        }

        public bool GetKDebit(int m_ikdbit)
        {

        }


    }
}

