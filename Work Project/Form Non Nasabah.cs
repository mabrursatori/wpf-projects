using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Project
{
    public partial class Form_Non_Nasabah : Form
    {
        public Form_Non_Nasabah()
        {
            InitializeComponent();
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            Form1 kembali = new Form1();
            this.Hide();
            kembali.ShowDialog();
        }
    }
}
