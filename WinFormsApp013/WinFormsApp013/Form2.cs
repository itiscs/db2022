using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp013.MyDataSetTableAdapters;

namespace WinFormsApp013
{
    public partial class Form2 : Form
    {
        MyDataSet ds = new MyDataSet();
        ProductsTableAdapter prodTA = new ProductsTableAdapter();
        CustomersTableAdapter custTA = new CustomersTableAdapter();
        OrdersTableAdapter ordersTA = new OrdersTableAdapter();

        public Form2()
        {
            InitializeComponent();
            prodTA.Fill(ds.Products);
            custTA.Fill(ds.Customers);
            ordersTA.Fill(ds.Orders);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            bindingSource1.DataSource = ds.Customers;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Refresh();
            bindingSource1.DataSource = ds.Products;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.Refresh();
            bindingSource1.DataSource = ds.Orders;
        }
    }
}
