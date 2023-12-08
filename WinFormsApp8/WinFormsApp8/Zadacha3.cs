using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp8.Models;
using WinFormsApp8.MyDataSetTableAdapters;

namespace WinFormsApp8
{
    public partial class Zadacha3 : Form
    {
        MyDataSet ds = new MyDataSet();
        Zadacha3TableAdapter adap = new Zadacha3TableAdapter();
        MyBase113Context db = new MyBase113Context();
        public Zadacha3()
        {
            InitializeComponent();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            var city = txtCity.Text;
            var price = decimal.Parse(txtPrice.Text);

            adap.Fill(ds.Zadacha3, city, price, dateTimePicker1.Value);
            dataGridView1.DataSource = ds.Zadacha3;
        }

        private void btnORM_Click(object sender, EventArgs e)
        {
            var prods = db.Products.ToList();
            var custs = db.Customers.ToList();
            var orders = db.Orders.ToList();

            var city = txtCity.Text;
            var price = decimal.Parse(txtPrice.Text);
            var date1 = dateTimePicker1.Value;

            var lst = new List<Z3>();

            foreach(var c in custs)
            {
                if (c.City != city)
                    continue;
                bool aProd = true;
                foreach (var p in prods)
                {
                    if (p.Price <= price)
                        continue;
                    bool eOrder = false;
                    foreach(var o in orders)
                        if(o.IdProd==p.Id && o.IdCust==c.Id &&
                            o.OrderDate < date1)
                        {
                            eOrder = true;
                            break;
                        }
                    if(!eOrder)
                    {
                        aProd = false;
                        break;
                    }                    
                }
                if(aProd) 
                {
                    lst.Add(new Z3()
                    {
                        Name = c.Name
                    });
                }
            }
            dataGridView1.DataSource = lst;
        }
    }
}
