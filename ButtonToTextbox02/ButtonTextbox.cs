using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonToTextbox02
{
    public partial class ButtonTextbox : Form
    {
        TextBox seltb = null;

        class  TClass 
        {
            public string Textbox { get; set; }
        }

        public ButtonTextbox()
        {
            InitializeComponent();
            textBox1.Enter += tb_enter;
            textBox2.Enter += tb_enter;
        }

        private void tb_enter(object sender, EventArgs e)
        {
            seltb = (TextBox)sender;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            seltb.SelectedText += "A";
            if (seltb != null) seltb.Focus();
        }
        private bool capslock = true;

        private int currentImageIndex = 2;

        

        private void buttonB_Click(object sender, EventArgs e)
        {
            //if (capslock)
            //{
            //    buttonB.BackColor = Color.Transparent;
            //    capslock = false;
            //}
            //else`
            //{
            //    buttonB.BackColor = Color.Red;
            //    capslock = true;
            //}
            //seltb.SelectedText += "B";
            //if (seltb != null) seltb.Focus();


            
        }

        private void ButtonTextbox_Load(object sender, EventArgs e)
        {
            //buttonB.Tag = "test caps color after.png";
            //buttonB.Image = new Bitmap(Path.Combine("Gambar01", buttonB.Tag.ToString()));

           pictureBox1.ImageLocation = @"C:\Users\Sysdev\source\repos\ButtonToTextbox02\Gambar01\07pass tidak terdaftar.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.test_caps_color_before;
        }

        TextBox focusedTB = null;
        private void button2_Click(object sender, EventArgs e)
        {
            if (focusedTB != null) focusedTB.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(textBox1.Text))
            //{
            //    Clipboard.SetText(textBox1.Text);
            //}

            string textbox  = textBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Clipboard.GetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = @"C:\Users\Sysdev\source\repos\ButtonToTextbox02\Gambar01\07pass tidak terdaftar.png";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }
    }
}
