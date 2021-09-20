using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_Keyboard
{
    public partial class Form1 : Form
    {
        private TextBox focusTB = null;
       

        public Form1()
        {
            InitializeComponent();
            textBox1.Enter += tb_enter;
            TextBox2.Enter += tb_enter;
        }
        ~Form1()
        {
            textBox1.Enter -= tb_enter;
            TextBox2.Enter -= tb_enter;
        }

        private void tb_enter(object sender, EventArgs e)
        {
            focusTB = (TextBox)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            focusTB.SelectedText += "c";
            if (focusTB != null) focusTB.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            focusTB.SelectedText += "A";
            if (focusTB != null) focusTB.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            focusTB = sender as TextBox;
        }
    }
}
