using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextboxInGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("No", typeof(int));

            dt.Columns.Add("Item", typeof(string));

            dt.Columns.Add("quantity", typeof(int));

            dt.Columns.Add("Price", typeof(decimal));

            //Add row to the datatable

            for (int i = 0; i < 10; i++)
            {

                //Not Sure what dtr is you looping through

                string no = dt.Rows[i][0].ToString();
                string item = dt.Rows[i][1].ToString() + " " + dt.Rows[i][1].ToString();
                string A_qty = dt.Rows[i][2].ToString();
                string price = dt.Rows[i][3].ToString();

                dt.Rows.Add(no, item, A_qty, price);
            }


            //Create New DataGridViewTextBoxColumn
            DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();

            //Bind DataGridView to Datasource
            dataGridView1.DataSource = dt;

            //Add TextBoxColumn dynamically to DataGridView
            dataGridView1.Columns.Add(textboxColumn);

            //Loop through DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)

            {

                //Do your task here
                string fourthColumn = row.Cells[4].Value.ToString();

            }
        }
    }
}
