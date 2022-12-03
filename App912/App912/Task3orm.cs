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
    public partial class Task3orm : Form
    {
        Base012Context db = new Base012Context();
        public Task3orm()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            bool allProd, exOrder;
            List<Task3> lst = new List<Task3>();
            var city = txtCity.Text;
            var price = int.Parse(txtPrice.Text);
            var date = dateTo.Value;

            foreach(var c in db.Customers.ToList())
            {
                if (c.City != city)
                    continue;
                allProd = true; 
                foreach(var p in db.Products.ToList())
                {
                    if (p.Price <= price)
                        continue;
                    exOrder = false;
                    foreach(var o in db.Orders.ToList())
                    {
                        if(o.IdProd==p.Id && o.IdCust==c.Id && o.OrderDate<date)
                        {
                            exOrder = true;
                            break;
                        }    
                    }
                    if(!exOrder)
                    {
                        allProd = false;
                        break;
                    }
                }
                if(allProd)
                {
                    lst.Add(new Task3() { Name = c.Name });
                }
            }

            dataGridView1.DataSource = lst;
        }
    }
}
