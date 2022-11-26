using App912.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App912
{



    public partial class Form2 : Form
    {
        Base012Context db = new Base012Context();

        public Form2()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Select(
                p => new {p.Id,p.Name,p.Price,p.EdIzm,p.Count}).ToList();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.ToList();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.ToList();

        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            List<Task1> lst = new List<Task1>();
            foreach(var ord in  db.Orders.ToList())
            {
                if(ord.Count > int.Parse(txtCount.Text))
                {
                    foreach(var prod in db.Products.ToList())
                    {
                        if(prod.Id == ord.IdProd)
                        {
                            lst.Add(new Task1()
                            {
                                ProductName = prod.Name,
                                OrderDate = ord.OrderDate,
                                Count = ord.Count,
                                Price = prod.Price,
                                Amount = ord.Amount
                            }) ;


                        }
                    }
                }
            }
            dataGridView1.DataSource = lst;
        }
    }
}
