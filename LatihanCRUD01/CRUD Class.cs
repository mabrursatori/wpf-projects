using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace LatihanCRUD01
{
    public class CRUD_Class
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB_DEMO"].ConnectionString);

        public string SO_NO { get; set; }
        public string ITEM_NAME { get; set; }
        public int QUANTITY { get; set; }
        public int PRICE { get; set; }

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet(); 

        public void Create_data()
        {
           
            con.Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO 'SALES_SO_LITEM'('ITEM_NAME','QUANTITY','PRICE') VALUES('@ITEM','@QUANTITY',@PRICE)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //cmd.Parameters.Add("@SO_NO", SqlDbType.VarChar).Value = SO_NO;
                cmd.Parameters.Add("@Item",SqlDbType.VarChar).Value = ITEM_NAME;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = QUANTITY;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = PRICE;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM 'TBL_SALES_SO'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}
