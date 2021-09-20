using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonToTextbox
{
    public partial class Form1 : Form
    {
        //private TextBox textBox = null;
        TextBox selTB = null;

        Control selectedTextbox { get; set; }

        public Form1()
        {
            InitializeComponent();
            //this.ActiveControl = textBox1;
            //textBox1.Focus();

            //this.ActiveControl = textBox2;
            //textBox2.Focus();

            //this.textBox1.GotFocus += new EventHandler(GetF);

            textBox1.Enter += tb_Enter;

            

        }

        private void tb_Enter(object sender, EventArgs e)
        {
            selTB = (TextBox)sender;
        }

        //private void TextBox_Click(object sender, EventArgs e)
        //{
        //    selectedTextbox = (Control)sender;
        //}

        //~Form1()
        //{
        //    textBox1.Enter -= tb_Enter;
        //}

        //Control ActiveControl;

        private void buttonA_Click(object sender, EventArgs e)
        {
            //if (textBox != null) textBox.SelectedText += "A";
            //if (textBox != null) textBox2.SelectedText += "A";
            //selTB.SelectedText += "A";

            //if (selTB != null) selTB.Focus();


            if (selectedTextbox == null)
                throw new Exception("not set");
            selectedTextbox.Text += "A";
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            //if (textBox != null) textBox.SelectedText += "B";
            //string B = "B";
            //textBox1.AppendText("B");

            //selTB.SelectedText += "B";

            //if (selTB != null) selTB.Focus();


            if (selectedTextbox == null)
                throw new Exception("not set");
            selectedTextbox.Text += "B";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ActiveControl = (Control)sender;
            selectedTextbox = (Control)sender;
        }
    }
}
