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

namespace TestLatihanC1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CoreDBTest"].ConnectionString);
        
		#region DBclass
        public class Tbl_Customer
		{
			public int Com_Customer_ID { get; set; }
			public string Customer_Name { get; set; }

			public Tbl_Customer(int Com_Customer_ID_, string Customer_Name_)
			{
				this.Com_Customer_ID = Com_Customer_ID_;
				this.Customer_Name = Customer_Name_;
			}
		}

		public class TBL_Sales_SO
		{
			public int Sales_SO_ID { get; set; }
			public string SO_NO { get; set; }
			public DateTime Order_Date { get; set; }
			public int Com_Customer_ID { get; set; }
			public string Adress { get; set; }

			public TBL_Sales_SO(int Sales_SO_ID_, string SO_NO_, DateTime Order_Date_, int Com_Customer_ID_, string Adress_)
			{
				this.Sales_SO_ID = Sales_SO_ID_;
				this.SO_NO = SO_NO_;
				this.Order_Date = Order_Date_;
				this.Com_Customer_ID = Com_Customer_ID_;
				this.Adress = Adress_;
			}
		}

		public class TBL_SO_LIITEM
		{
			public int Sales_So_Liitem_ID { get; set; }
			public int Sales_So_ID { get; set; }
			public string Item_Name { get; set; }
			public int Quantity { get; set; }
			public double Price { get; set; }

			public TBL_SO_LIITEM(int Sales_So_Liitem_ID_, int Sales_So_ID_, string Item_Name_, int Quantity_, double Price_)
			{
				this.Sales_So_Liitem_ID = Sales_So_Liitem_ID_;
				this.Sales_So_ID = Sales_So_ID_;
				this.Item_Name = Item_Name_;
				this.Quantity = Quantity_;
				this.Price = Price_;
			}
		}
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_DEMODataSet.SALES_SO' table. You can move, or remove it, as needed.
            this.sALES_SOTableAdapter.Fill(this.dB_DEMODataSet.SALES_SO);
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "SELECT TBL_Sales_SO.SO_NO, Tbl_Customer.Customer_Name, TBL_Sales_SO.Order_Date,TBL_Sales_SO.Adress, TBL_SO_LIITEM.Item_Name, TBL_SO_LIITEM.Quantity, TBL_SO_LIITEM.Price FROM((Tbl_Customer INNER JOIN TBL_Sales_SO on Tbl_Customer.Com_Customer_ID = TBL_Sales_SO.Com_Customer_ID)INNER JOIN TBL_SO_LIITEM on TBL_Sales_SO.Com_Customer_ID = TBL_SO_LIITEM.Sales_So_ID)WHERE Customer_Name = 'MURNI'";
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);

            //dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //con.Close();




            comboBox1.Items.Add("Murni");
			comboBox1.Items.Add("Solusindo");
		
		
		}

        private void button1_Click(object sender, EventArgs e)
        {
			
			dataGridView1.Rows.Add("");
		}
    }
}
