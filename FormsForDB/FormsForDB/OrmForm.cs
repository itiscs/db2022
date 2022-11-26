using FormsForDB.Models;
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
    public partial class OrmForm : Form
    {
        MyBaseContext db = new MyBaseContext();
        public OrmForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {            
            dataGridView1.DataSource = db.Customers.Select(c => new {c.Id, c.Name,
            c.City,c.Address,c.Phone}).ToList();
            lblTableName.Text = "Покупатели";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Select(p => new {p.Id, p.Name,
            p.EdIzm, p.Price, p.Count}).ToList();
            lblTableName.Text = "Товары";
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Select(o => new {o.Id, o.Orderdate,
            o.Count, o.Amount, o.IdCust, o.IdProd}).ToList();
            lblTableName.Text = "Заказы";
        }
    }
}
