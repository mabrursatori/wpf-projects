using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Winform_animate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        DoubleAnimation widthAnimation = new DoubleAnimation(120, 300, TimeSpan.FromSeconds(5))
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ToString());
        }
    }
}
