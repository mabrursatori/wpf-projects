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
using System.Configuration;

namespace SoalTestMurniC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CoreDBTest"].ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(@"SELECT SO.SO_NO,SO.Order_Date,C.Customer_Name FROM TBL_Sales_SO SO JOIN Tbl_Customer C ON SO.Com_Customer_ID = C.Com_Customer_ID", con);
            con.Open();
            
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales_Order_Input SOI = new Sales_Order_Input();
            this.Hide();
            SOI.Show();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            #region Keyword Only
            //string main = ConfigurationManager.ConnectionStrings["CoreDBTest"].ConnectionString;
            //SqlConnection con = new SqlConnection(main);
            ////string query = "SELECT SO.SO_NO, SO.Order_Date, C.Customer_Name FROM" + " TBL_Sales_SO SO JOIN Tbl_Customer C ON SO.Com_Customer_ID = C.Com_Customer_ID " + "WHERE Customer_Name Like '" + textBox1.Text + "'";
            //string query = "SELECT SO.SO_NO, SO.Order_Date, C.Customer_Name FROM" + " TBL_Sales_SO SO JOIN Tbl_Customer C ON SO.Com_Customer_ID = C.Com_Customer_ID " + "WHERE Customer_Name = '" + textBox1.Text + "' AND Order_Date BETWEEN @FROMVALUE AND @DATEVALUE ";


            //con.Open();
            //SqlCommand command = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
            #endregion

            //string query = "SELECT SO.SO_NO, SO.Order_Date, C.Customer_Name FROM" + " TBL_Sales_SO SO JOIN Tbl_Customer C ON SO.Com_Customer_ID = C.Com_Customer_ID " + "WHERE Customer_Name = '" + textBox1.Text + "' AND Order_Date BETWEEN @FROMVALUE AND @DATEVALUE ";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CoreDBTest"].ConnectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("SELECT SO.SO_NO, SO.Order_Date, C.Customer_Name FROM" + " TBL_Sales_SO SO JOIN Tbl_Customer C ON SO.Com_Customer_ID = C.Com_Customer_ID " + "WHERE Customer_Name = '" + textBox1.Text + "' AND Order_Date BETWEEN @FROMVALUE AND @DATEVALUE ",con);

            command.Parameters.AddWithValue("@FROMVALUE", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@DATEVALUE", dateTimePicker2.Value);
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Sales_Order_Input SOI = new Sales_Order_Input();
            this.Hide();
            SOI.Show();
        }
    }
}
