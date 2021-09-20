using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Work_Project
{
    class Fungsi_Baca_KD
    {
        SqlConnection con = new SqlConnection("Data Source=DEV-4\\SQLEXPRESS;Initial Catalog=CoreDBTest;Integrated Security=True");
        public string methodClass()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Name From TblNames2 where Name ='" + textBox1.Text + "' ", con);
        }

        
      
    }
}
