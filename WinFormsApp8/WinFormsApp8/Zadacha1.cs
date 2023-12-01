using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp8.Models;
using WinFormsApp8.MyDataSetTableAdapters;

namespace WinFormsApp8
{
    public partial class Zadacha1 : Form
    {
        MyDataSet ds = new MyDataSet();
        DataTable1TableAdapter adap = new DataTable1TableAdapter();
        MyBase113Context db = new MyBase113Context();
        public Zadacha1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            int kol = int.Parse(txtKol.Text);
            adap.Fill(ds.DataTable1, kol);
            dataGridView1.DataSource = ds.DataTable1;
        }

        private void btnORM_Click(object sender, EventArgs e)
        {
            var lst = new List<Z1>();
            var orders = db.Orders.ToList();
            var prods = db.Products.ToList();

            int kol = int.Parse(txtKol.Text);

            foreach ( var order in orders) 
            {
                if (order.Count < kol)
                    continue;

                foreach( var product in prods) 
                {
                    if(order.IdProd == product.Id)
                    {
                        lst.Add(new Z1()
                        {
                            Name = product.Name,
                            Price = product.Price,
                            OrderDate = order.OrderDate,
                            Count = order.Count,
                            Amount = order.Amount
                        });
                    }
                }
            }

            dataGridView1.DataSource = lst;
        }
    }
}
