using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp8.Models;

namespace WinFormsApp8
{
    public partial class AltForm : Form
    {
        MyBase113Context db = new MyBase113Context();
        public AltForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.ToList();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.ToList();
        }
    }
}
