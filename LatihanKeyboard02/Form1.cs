using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanKeyboard02
{
    public partial class Form1 : Form
    {
        #region Variable

        TextBox txtbox = null;
        private bool capslock = true;
        private TextBox focusTB = null; //test BackSpace

        #endregion

        //Test Keyboard sudah Berhasil, mohon jangan di ubah2 lagi

        public Form1()
        {
            InitializeComponent();
            textBox1.Enter += tb_enter;
            textBox2.Enter += tb_enter;

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Enter += textbox_enter;
            }

        }

        private void textbox_enter(object sender, EventArgs e)
        {
            focusTB = (TextBox)sender;
        }

        ~Form1()
        {
            textBox1.Enter -= tb_enter;
            textBox2.Enter -= tb_enter;
        }

        private void tb_enter(object sender, EventArgs e)
        {
            txtbox = (TextBox)sender;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            if (capslock)
            {
                txtbox.SelectedText += "a";
            }
            //if (txtbox != null) txtbox.Focus(); 
            else
            {
                txtbox.SelectedText += "A";
            }
            
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            if (capslock)
            {
                txtbox.SelectedText += "b";
            }
            //if (txtbox != null) txtbox.Focus(); 
            else
            {
                txtbox.SelectedText += "B";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (capslock)
            {
                txtbox.SelectedText += "c";
            }
            //if (txtbox != null) txtbox.Focus(); 
            else
            {
                txtbox.SelectedText += "C";
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            txtbox.SelectedText += "d";
            if (txtbox != null) txtbox.Focus();
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            txtbox.SelectedText += "e";
            if (txtbox != null) txtbox.Focus();
        }

        private void BtnCaps_Click(object sender, EventArgs e)
        {
            if (capslock)
            {
                capslock = false;
            } 
            else
            {
                capslock = true;
            }
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (focusTB != null)
            {
                if (textBox1.Text == focusTB.Text)
                {
                    if (textBox1.Text.Length > 0)
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                else
                {
                    if (textBox2.Text == focusTB.Text)
                    {
                        if (textBox2.Text.Length > 0)
                            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                    }
                }
            }
        }
    }
}
