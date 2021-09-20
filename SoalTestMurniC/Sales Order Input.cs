using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using SoalTestMurniC.Properties;


namespace SoalTestMurniC
{
    public partial class Sales_Order_Input : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CoreDBTest"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        

        Crud Crd = new Crud();
        DataTable dt = new DataTable("SO_INPUT");
        DataSet ds = new DataSet("INPUTDATASET");
        SqlCommandBuilder cb = new SqlCommandBuilder();

        #region Method

        public void READ()
        {
            dataGridView1.DataSource = null;
            Crd.ReadData();
            dataGridView1.DataSource = Crd.dt;
        }

        public void DELETE()
        {
            
        }

        #endregion

        public Sales_Order_Input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Connected");
        }

        private void Btn_Add_Item_Click(object sender, EventArgs e)
        {
            dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
        }

        private void Sales_Order_Input_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"select SO.ID,SO.ITEM_NAME,so.QUANTITY,SO.PRICE,SO.TOTAL from SO_INPUT SO", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           //if (dataGridView1.CurrentCell.ColumnIndex == 0)
           // {
           //     if (e.Control != null && e.Control is TextBox)
           //     {
           //         e.Control.KeyPress += delegate (object MySender, KeyPressEventArgs MyE)
           //         {
           //             if (!char.IsDigit(MyE.KeyChar))
           //             {
           //                 MyE.Handled = true;
           //             }
           //         };
           //     }
           // }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
              
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            cb = new SqlCommandBuilder(sda);
            cb.GetDeleteCommand();
            sda.Update(dt);
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            cb = new SqlCommandBuilder(sda);
            cb.GetInsertCommand();
            sda.Update(dt);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Sales_Order_Input soi = new Sales_Order_Input();
            this.Hide();
            soi.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            U_ID.Text = dr.Cells[0].Value.ToString();
            U_Quantity.Text = dr.Cells[1].Value.ToString();
            U_Price.Text = dr.Cells[2].Value.ToString();
            U_Total.Text = dr.Cells[3].Value.ToString();
            U_Item.Text = dr.Cells[4].Value.ToString();
        }
    }
}
