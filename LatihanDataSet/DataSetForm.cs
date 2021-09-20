using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanDataSet
{
    public partial class DataSetForm : Form
    {
        public DataSetForm()
        {
            InitializeComponent();
        }

        DataSet set01 = new DataSet("Set Latihan 01");
        DataSet set02 = new DataSet("Set Latihan 02");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataSetForm_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable("Detail 01");
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Nama Produk", typeof(String));
            dt.Rows.Add(01, "Apel Fuji");
            dt.Rows.Add(02, "Banana Sunrise");
            //DataSet set01 = new DataSet("Set Latihan 01");
            set01.Tables.Add(dt);

            DataTable Tabel02 = new DataTable("Detail 02");
            Tabel02.Columns.Add("ID", typeof(Int32));
            Tabel02.Columns.Add("Nama Produk", typeof(String));
            Tabel02.Rows.Add(01, "Soda Kue");
            Tabel02.Rows.Add(02, "Soda Api");
            //DataSet set02 = new DataSet("Set Latihan 02");
            set02.Tables.Add(Tabel02);



            dataGridView1.DataSource = Tabel02;

        }

        private void SVE_Button_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "XML|*.xml";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        dsa.Tables[0].WriteXml(sfd.FileName);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex);
            //    }
            //}

          
        }
    }
}
