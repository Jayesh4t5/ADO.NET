using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        ProductCrud crud;
        public Form1()
        {
            InitializeComponent();
            crud = new ProductCrud();   
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

            private void label3_Click(object sender, EventArgs e)
        {

        }

            private void Form1_Load(object sender, EventArgs e)
            {
                List<Category1> list = crud.GetCategories();
                cmbcategory.DataSource = list;
                cmbcategory.DisplayMember = "Cname";
                cmbcategory.ValueMember = "Cid";


            }

            private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
