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
    public partial class Task1orm : Form
    {
        Base012Context db = new Base012Context();
        public Task1orm()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            List<Task1> lst = new List<Task1>();
            var count = int.Parse(txtCount.Text);

            foreach (var ord in db.Orders.ToList())
            {
                if (ord.Count > count)
                {
                    foreach (var prod in db.Products.ToList())
                    {
                        if (prod.Id == ord.IdProd)
                        {
                            lst.Add(new Task1()
                            {
                                ProductName = prod.Name,
                                OrderDate = ord.OrderDate,
                                Count = ord.Count,
                                Price = prod.Price,
                                Amount = ord.Amount
                            });


                        }
                    }
                }
            }
            dataGridView1.DataSource = lst;
        }
    }
}
