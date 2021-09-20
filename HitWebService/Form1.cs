using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;
using Common;
using Auth_BLL_Test.Auth_Folder;
using System.Runtime.InteropServices;
using Auth_BLL_Test.localhost;
using System.Text;

namespace HitWebService
{
    

    public partial class Form1 : Form
    {


        localhost.WebService1 proxy = new localhost.WebService1(); //Yang Benar //
        


        public Form1()
        {
            InitializeComponent();
            ClassManggil();
        }

        public void ClassManggil()
        {
            listBox1.Items.Add(Name);

        }

        public int returnKD(int noKartu)
        {
            int a = 0;
            a = noKartu + 100;

            return a;

        }
        public string returnKD2 /* hasil balikkan */   (int noKartu) /* Input nya */
        {
            int a = 0;
            String b;
            a = noKartu + 100;
            b = a.ToString();

            return  b;
            // ini di class
        }
        


        public void SwipeKartu()
        {
            int c;
            
            c = returnKD(15);
        }

        public bool RTkartu()
        {
            bool nokartu = false;
            {
                
            }
            return nokartu;
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            //client.add

            string countriesJson = proxy.Countries();
            DataTable dtCountries = JsonConvert.DeserializeObject<DataTable>(countriesJson);

            dataGridView1.DataSource = dtCountries;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //string countriesJson = proxy.Countries();
            //DataTable dtCountries = JsonConvert.DeserializeObject<DataTable>(countriesJson);

            //dataGridView1.DataSource = dtCountries;

            localhost.WebService1 proxy = new localhost.WebService1();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
