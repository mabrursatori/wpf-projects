using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachLoopForm
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
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            char names;

            List<int> Grades = new List<int>() { 5, 10, 15, 20 };
            String[] Names = {"Yosua","John","Marc","Bob" };

            for(int i = 0; i<Grades.Count; i++)
            {
               
               
                dt.Rows.Add(Grades[i]);

            }

            dataGridView1.DataSource = dt;
        }
    }
}
