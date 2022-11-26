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
    }
}



