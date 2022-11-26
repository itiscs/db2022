using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp013.Models;

namespace WinFormsApp013
{
    public partial class OrmForm : Form
    {
        Base013Context db = new Base013Context();
        public OrmForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers
              .Select(c => new { c.Id, c.Name, c.Address, c.City, c.Phone })
              .ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= db.Orders.ToList();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {


        }
    }
}
