using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp013.Models;
using WinFormsApp013.MyDataSetTableAdapters;

namespace WinFormsApp013
{
    public partial class Task3form : Form
    {
        MyDataSet ds = new MyDataSet();
        Task3TableAdapter adap = new Task3TableAdapter();
        Base013Context db = new Base013Context();

        public Task3form()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            var city = txtCity.Text;
            var price = int.Parse(txtPrice.Text);
            var date1 = dateTo.Value;
            adap.Fill(ds.Task3, city, price, date1);
            dataGridView1.DataSource = ds.Task3;
        }

        private void btnORM_Click(object sender, EventArgs e)
        {
            bool allProd, exOrd;
            var city = txtCity.Text;
            var price = int.Parse(txtPrice.Text);
            var date1 = dateTo.Value;
            List<Task3> lst = new List<Task3>();

            foreach(var c in db.Customers.ToList())
            {
                if (c.City != city)
                    continue;
                allProd = true;
                foreach(var p in db.Products.ToList())
                {
                    if (p.Price <= price)
                        continue;
                    exOrd = false;
                    foreach(var o in db.Orders.ToList())
                    {
                        if(o.IdProd==p.Id && o.IdCust==c.Id && o.Orderdate<date1)
                        {
                            exOrd = true;
                            break;
                        }
                    }
                    if(!exOrd)
                    {
                        allProd = false;
                        break;
                    }
                }
                if(allProd) 
                {
                    lst.Add(new Task3() { Name = c.Name});
                }
            }
            dataGridView1.DataSource = lst;

        }
    }
}
