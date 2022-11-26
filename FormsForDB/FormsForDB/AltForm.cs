using FormsForDB.MyDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsForDB
{
    public partial class AltForm : Form
    {
        MyDataSet ds = new MyDataSet();
        CustomersTableAdapter custTA = new CustomersTableAdapter();
        ProductsTableAdapter prodTA = new ProductsTableAdapter();
        OrdersTableAdapter ordTA = new OrdersTableAdapter();

        public AltForm()
        {
            InitializeComponent();
        }

        private void AltForm_Load(object sender, EventArgs e)
        {
            custTA.Fill(ds.Customers);
            prodTA.Fill(ds.Products);
            ordTA.Fill(ds.Orders);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Customers;
            lblTableName.Text = "Покупатели";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Products;
            lblTableName.Text = "Товары";
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Orders;
            lblTableName.Text = "Заказы";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            custTA.Update(ds.Customers);
            prodTA.Update(ds.Products);
            ordTA.Update(ds.Orders);
            MessageBox.Show("Изменения сохранены!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
