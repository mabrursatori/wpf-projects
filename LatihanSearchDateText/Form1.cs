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



namespace LatihanSearchDateText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            #region test 1
            //SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB_DEMO"].ConnectionString);
            //DateTime date = dateTimePicker1.Value.Date;
            //string querry = "SELECT * FROM STUDENT where STUDENT_ADMISSION <=@Datum";

            //SqlCommand command = new SqlCommand(querry,con);
            //command.Parameters.AddWithValue("@Datum", date);
            #endregion

           

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_DEMO"].ConnectionString);
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM MEMBER m WHERE m.MEMBER_DATE BETWEEN @FROMDATE AND @TODATE AND M.MEMBER_ID = '"+ textBox1.Text +"' ", con);

            command.Parameters.AddWithValue("@FROMDATE", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@TODATE", dateTimePicker2.Value);
            
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB_DEMO"].ConnectionString);
            //SqlDataAdapter sda = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            //sda = new SqlDataAdapter(@"SELECT * FROM STUDENT",con);
            //con.Open();

            //dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NilaiValue value = new NilaiValue();

            value.U_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            value.U_Name.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            value.U_Date.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            this.Hide();
            value.Show();

        }
    }
}
