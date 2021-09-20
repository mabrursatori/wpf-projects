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
using ServiceStack.Data;
using ServiceStack.Text;

namespace DataGridButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Check
        {
            public bool UseColumnTextForButtonValue { get; set; }
        }

        public class Comments
        {
            public Guid ID { get; set; }

            public string Name { get; set; }

            public string Email { get; set; }

            public string Comment { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            

            //DataGridViewButtonColumn uninstall = new DataGridViewButtonColumn();
            //uninstall.Name = "Uninstall_Column";
            //uninstall.Text = "Uninstall";

            //int columnIndex = 2;
            //if (dataGridView1.Columns["uninstall_column"] == null)
            //{
            //    dataGridView1.Columns.Insert(columnIndex, uninstall);
            //}

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region test
            // TODO: This line of code loads data into the 'coreDBTestDataSet.Tbl_Customer' table. You can move, or remove it, as needed.
            //this.tbl_CustomerTableAdapter.Fill(this.coreDBTestDataSet.Tbl_Customer);
            //DataTable dt = new DataTable();
            //dt.Columns.Add("01");
            //dt.Columns.Add("02");
            //dt.Columns.Add(new DataColumn("Software Title", typeof(string)));
            //dt.Columns.Add(new DataColumn("Version", typeof(string)));
            #endregion

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Buttons";
            btn.Name = "Button";
            btn.Text = "click";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);

            #region Sudah Berjalan
            //var select = "SELECT * FROM Tbl_Customer";
            //var c = new SqlConnection(@"Data Source=DEV-4\SQLEXPRESS;Initial Catalog=CoreDBTest;Integrated Security=True");
            //var dataAdapter = new SqlDataAdapter(select, c);

            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //var ds = new DataSet();
            //dataAdapter.Fill(ds);
            //dataGridView1.ReadOnly = true;
            //dataGridView1.DataSource = ds.Tables[0];
            #endregion





        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
