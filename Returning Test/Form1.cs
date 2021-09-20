using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Returning_Test
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public class return2
        {
            public string LastFirst (string firstname, string lastname)
            {
                string separator = ", ";
                string result = lastname + separator + firstname;
                return result;
            }

        }

        public static class Return3
        {
            public static string GetIsValidNumberMessgae(string text)
            {
                string message;
                int number;
                if (int.TryParse(text, out number))
                {
                    if (number > 10)
                        message = "Number must be below 10";
                    else
                        message = "Good !  You entered : " + number;
                }
                else
                    message = "Not valid number";
                return message;
                
            }
        }

        public static class Return4
        {
            public static string KodeKartu(string text)
            {
                string Pesan;
                int DigitPin;
                if (int.TryParse(text, out DigitPin))
                {
                    if (DigitPin < 9999999999)
                        Pesan = "Silahkan Lanjut ke transaksi";
                    else
                        Pesan = "Nomor Pin Anda Salah";
                }
                else
                    Pesan = "Not Valid Number";
                return Pesan;
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Return4.KodeKartu(textBox1.Text));
        }
    }
}
