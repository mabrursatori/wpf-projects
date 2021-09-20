using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Auth_BLL_Test.Auth_Folder;

namespace Hitting_Postman
{
    public partial class FrmPostman : Form
    {
        #region Constructor

        public FrmPostman()
        {
            InitializeComponent();
        }



        #endregion

        private void FrmPostman_Load(object sender, EventArgs e)
        {
            try
            {
                string TestPostData = "auth_type=" + "5" + "card_id=" + "123512" + "card_pin=" + "123414";
                string sAuth = string.Empty;
                string sURL = "http://192.168.8.40:30003/authwsdl";

                JsonHit jsonHit = new JsonHit();
                jsonHit.ApiInputIdPassword(TestPostData, sURL, out sAuth);
            }

            catch
            {
                
            }
        }
    }
}
