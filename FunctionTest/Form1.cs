using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auth_BLL_Test;
using  Auth_BLL_Test.Auth_Folder;
using static FunctionTest.tesclas;

namespace FunctionTest
{
    public partial class Form1 : Form
    {
        //public string color = "red";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0 ;
            a = returnKD(15);

            textBox2.Text = a.ToString();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Di Bawah Ini Contoh Pemanggilan Class */
            //Car myOBJ = new Car();
            //textBox1.Text = myOBJ.color;

            ReturnDebitString RDS = new ReturnDebitString();
            //textBox1.Text = RDS.returnKD2();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = 0;
            a /* Output*/= returnKD(10) /* Input */;
            MessageBox.Show(a.ToString(), "");

            //int a = 0;
            
            //a = WaitnoKartu();
            //MessageBox.Show(a.ToString(),"");
            
        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ////int InputDigit = 10;
            ////int Digit;
            ////Digit = GetInputKodePin(10);
            ////textBox2.Text = Digit.ToString();

            //int Angka = 123;
            //bool Valid = false;
            //while (Valid == true)
            //{
            //    WaitnoKartu(Valid,Angka);
            //    MessageBox.Show(Valid.ToString(), Angka.ToString());
            //}

            //MessageBox.Show("",Valid.ToString());

            ////MessageBox.Show(WaitnoKartu(Valid,Angka, "");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = "0";
            a /* Output*/= ApaIni(Int16.Parse(a)); /* Input */;

            MessageBox.Show(a.ToString(), ""); // String to Int

            //string a ="" ;
            //a = ApaIniString(a);
            //MessageBox.Show(a,"");
        }
    }
}
