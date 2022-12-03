using App912.DataSet912TableAdapters;
using Microsoft.EntityFrameworkCore;

namespace App912
{
    public partial class Form1 : Form
    {
        DataSet912 ds = new DataSet912();
        CustomersTableAdapter custTA = new CustomersTableAdapter();
        ProductsTableAdapter prodTA = new ProductsTableAdapter();
        OrdersTableAdapter ordTA = new OrdersTableAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            custTA.Fill(ds.Customers);
            prodTA.Fill(ds.Products);
            ordTA.Fill(ds.Orders);
            productsBindingSource.DataSource = ds.Products;
            customersBindingSource.DataSource = ds.Customers;
            ordersBindingSource.DataSource = ds.Orders;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            custTA.Update(ds.Customers);
            prodTA.Update(ds.Products);
            ordTA.Update(ds.Orders);
            MessageBox.Show("Changes saved!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            custTA.Fill(ds.Customers);
            prodTA.Fill(ds.Products);
            ordTA.Fill(ds.Orders);
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1sql f = new Task1sql();
            f.ShowDialog();
        }

        private void oRMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task1orm f = new Task1orm();
            f.ShowDialog();
        }

        private void sQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task3sql f = new Task3sql();
            f.ShowDialog();
        }

        private void oRMToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Task3orm f = new Task3orm();
            f.ShowDialog();
        }
    }
}



