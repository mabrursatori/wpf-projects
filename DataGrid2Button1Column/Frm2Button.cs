using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid2Button1Column
{
    public partial class Frm2Button : Form
    {
        public Frm2Button()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            dataGridView1.Columns.Add("col1", "Name");
            dataGridView1.Columns.Add("col2", "Age");

            //adding two button columns:
            DataGridViewButtonColumn btnColumn1 = new DataGridViewButtonColumn();
            btnColumn1.Name = "col3";
            btnColumn1.HeaderText = "Edit";
            btnColumn1.Text = "editing";
            btnColumn1.UseColumnTextForButtonValue = true;
            btnColumn1.CellTemplate.Style.BackColor = Color.GreenYellow;

            DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
            btnColumn2.Name = "col4";
            btnColumn2.HeaderText = "Delete";
            btnColumn2.Text = "deleting";
            btnColumn2.UseColumnTextForButtonValue = true;
            btnColumn2.CellTemplate.Style.BackColor = Color.Orange;

            dataGridView1.Columns.Add(btnColumn1);
            dataGridView1.Columns.Add(btnColumn2);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //add some rows as example:
            dataGridView1.Rows.Add("Name 1", "23");
            dataGridView1.Rows.Add("Name 2", "35");

            //create an event:
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["col3"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to edit the row?", "", MessageBoxButtons.YesNo))
                {
                    //delete it!          
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["col4"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete the row?", "", MessageBoxButtons.YesNo))
                {
                    //edit it!          
                }
            }
        }
    }
}
