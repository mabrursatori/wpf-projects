using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanCRUD01
{
    public partial class Form1 : Form
    {
        CRUD_Class crud = new CRUD_Class();
        public Form1()
        {
            InitializeComponent();
        }

        public void Create()
        {
            crud.ITEM_NAME = textBox1.Text;
            crud.QUANTITY = Int16.Parse( textBox2.Text);
            crud.PRICE = Int32.Parse(textBox3.Text);
            crud.Create_data();

        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            Create();
            crud.Read_data();
        }
    }
}
