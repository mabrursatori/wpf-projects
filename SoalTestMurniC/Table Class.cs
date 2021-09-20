using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SoalTestMurniC
{
    class DB
    {
        public SqlConnection con;

        public DB()
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CoreDBTest"].ConnectionString);


        }
    }

    

    class Crud : DB
    {
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        #region properties
        public class Tbl_Customer
        {
            public int Com_Customer_ID { get; set; }
            public string Customer_Name { get; set; }

            //public Tbl_Customer(int Com_Customer_ID_, string Customer_Name_)
            //{
            //    this.Com_Customer_ID = Com_Customer_ID_;
            //    this.Customer_Name = Customer_Name_;
            //}
        }

        public class TBL_Sales_SO
        {
            public int Sales_SO_ID { get; set; }
            public string SO_NO { get; set; }
            public DateTime Order_Date { get; set; }
            public int Com_Customer_ID { get; set; }
            public string Adress { get; set; }

            //public TBL_Sales_SO(int Sales_SO_ID_, string SO_NO_, DateTime Order_Date_, int Com_Customer_ID_, string Adress_)
            //{
            //    this.Sales_SO_ID = Sales_SO_ID_;
            //    this.SO_NO = SO_NO_;
            //    this.Order_Date = Order_Date_;
            //    this.Com_Customer_ID = Com_Customer_ID_;
            //    this.Adress = Adress_;
            //}
        }

        public class TBL_SO_LIITEM
        {
            public int Sales_So_Liitem_ID { get; set; }
            public int Sales_So_ID { get; set; }
            public string Item_Name { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            //public TBL_SO_LIITEM(int Sales_So_Liitem_ID_, int Sales_So_ID_, string Item_Name_, int Quantity_, double Price_)
            //{
            //    this.Sales_So_Liitem_ID = Sales_So_Liitem_ID_;
            //    this.Sales_So_ID = Sales_So_ID_;
            //    this.Item_Name = Item_Name_;
            //    this.Quantity = Quantity_;
            //    this.Price = Price_;
            //}
        }
        #endregion

        #region Properties
        public string SO_NO { get; set; }
        public int Sales_SO_ID { get; set; }
        public string Adress { get; set; }
        public string Item_Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public long ID { get; set; }
        public DateTime Order_Date { get; set; }
        #endregion
        public void Create_Data()
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "insert into 'TBL_Sales_SO','SO_INPUT'('Sales_SO_ID','Order_Date','Customer_Name','ADDRESS','ID','Quantity','Price')'VALUES(@Sales_SO_ID,@Address,@Order_Date,@Customer_Name,@Adress,@ID,@Quantity,@Price)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Sales_SO_ID", SqlDbType.Int).Value = Sales_SO_ID;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = Adress;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Delete()
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "DELETE FROM SO_INPUT WHERE ID=@ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ReadData()
        {
            dt.Clear();
            string query = "SELECT I.Item_Name,I.Price,I.Quantity,I.Price FROM TBL_SO_LIITEM I ";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.Fill(ds);
            dt = ds.Tables[0];
        }

    }

}
