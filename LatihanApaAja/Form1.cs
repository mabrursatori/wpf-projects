using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Linq;

namespace LatihanApaAja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet set01 = new DataSet("Set Latihan 01");
        DataSet set02 = new DataSet("Set Latihan 02");
        string test;
        string test2;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*

            DataTable Tabel1 = new DataTable("Kolom 1");
            Tabel1.TableName = "Test 01";
            Tabel1.Columns.Add("Detail 1");
            Tabel1.Columns.Add("Detail 2");
            
            for (int i = 0; i <Tabel1.Columns.Count; i++)
            {
                Tabel1.Columns[i].AllowDBNull = false;
            }

            DataColumn[] unique_cols =
            {
                Tabel1.Columns["Detail 1"],
                Tabel1.Columns["Detail 2"]
            
            };
            Tabel1.Constraints.Add(new UniqueConstraint(unique_cols));

            Tabel1.Rows.Add(new object[] { "DATA 01", "DATA 02" });
            Tabel1.Rows.Add(new object[] { "DATA 03", "DATA 04" });
            
            dataGridView1.DataSource = Tabel1;

            
            */

            /* Contoh Data Set */



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
            set01.Tables.Add(Tabel02);

            DataTable Tabel03 = new DataTable("Detail 03");
            Tabel03.Columns.Add("ID", typeof(Int32));
            Tabel03.Columns.Add("Nama Produk", typeof(String));
            Tabel03.Rows.Add(01, "Paku Kayu");
            Tabel03.Rows.Add(02, "Paku Beton");
            set01.Tables.Add(Tabel03);
            // Kode Hari INI //
            

            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReader xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                    set02.ReadXml(xmlFile);
                    dataGridView1.DataSource = set02.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        }

        private void svebttn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    set02.Tables[0].WriteXml(sfd.FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string intro = " nama produk anda ";
            test = dataGridView1.SelectedRows[0].Cells["Nama Produk"].Value.ToString();
            

            MessageBox.Show(test+"",intro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }

        private void TR_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string test = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string test2 = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                textBox1.Text = test+"   "+ test2;
            }
        }
    }
}
        