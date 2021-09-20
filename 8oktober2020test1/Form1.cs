using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _8oktober2020test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* kode hari ini saat test ==================
             
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("ConfigAPI.xml");
            DataView dataview = new DataView();
            BindingSource source = new BindingSource();
            source.DataSource = dataview;
            dataGridView1.DataSource = source;

            DataView firstDataView = new DataView(dataSet.Tables["FirstLevel"]);
            DataView dataElement = firstDataView[0].CreateChildView("FirstLevel");
            //firstDataView.RowFilter = "Id = 1";


            //DataView secondDataView = firstDataView[0].CreateChildView("FirstLevel_SecondLevel");
            //secondDataView.RowFilter = "Id = 2";

            //DataView thirdDataView = secondDataView[0].CreateChildView("SecondLevel_ThirdLevel");
            //DataView dataElement = thirdDataView[0].CreateChildView("ThirdLevel_DataElement");
            
            source.DataSource = dataElement;

            dataGridView1.DataSource = source;

            ===========================================================================*/

            string[] row1 = new string[] { "test 01", "test 02" };
            string[] row2 = new string[] { "test 03", "test 04" };
            string[] row3 = new string[] { "test 05", "test 06" };
            dataGridView1.Columns.Add("Kolom 1", "Kolom 2");
            //dataGridView1.Columns.Add("Kolom 3", "Kolom 4");
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.ReadOnly = true;
            }

            dataGridView1.Rows[1].ReadOnly = true;

        }
        /*
        private void AddColumn(DataTable table)
        {
            DataColumn column = table.Columns.Add("Total");
            column.DataType = System.Type.GetType("System Decimal");
            column.ReadOnly = true;
            column.Expression = "UnitPrice * Quantity";
            column.Unique = false;
        }

        */
    }
}
