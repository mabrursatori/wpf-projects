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
    public partial class Form_Nasabah : Form
    {
        public Form_Nasabah()
        {
            InitializeComponent();
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            Form1 pilihan = new Form1();
            this.Hide();
            pilihan.ShowDialog();
        }
    }
}
