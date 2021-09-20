using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassFunction02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int sum (int a)
        {
            int bilangan1 = 10;
            int bilangan2 = 20;
            int c = bilangan1 + bilangan2;
            return c;
        } 

        public int RequestKodeDebit (int KodeDebit )
        {
            int DigitKodeDebit;
            DigitKodeDebit = KodeDebit + 100;



            return DigitKodeDebit;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            #region Untuk Check Debug
            int a = 0;
            a = sum(a);

            //MessageBox.Show(a.ToString());           
            //textBox1.Text = text01.ToString();

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox3.Clear();
                return;
            }

            textBox3.Text = textBox2.Text;
            
        }
    }
   
}
