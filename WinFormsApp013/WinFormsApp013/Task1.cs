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
    public partial class Task1Form : Form
    {
        MyDataSet ds = new MyDataSet();
        Base013Context db = new Base013Context();
        Task1TableAdapter task1TA = new Task1TableAdapter();
        public Task1Form()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnORM_Click(object sender, EventArgs e)
        {
            
            var result = new List<Task1>();
            

            foreach(var order in db.Orders.ToList()) 
            { 
                if(order.Count > int.Parse(txtCount.Text))
                {
                    foreach(var prod in db.Products.ToList())
                        if(prod.Id == order.IdProd)
                        {
                            var t1 = new Task1();
                            t1.ProductName = prod.Name;
                            t1.OrderDate = order.Orderdate;
                            t1.Price = prod.Price;
                            t1.Count = order.Count;
                            t1.Amount = order.Amount;
                            result.Add(t1);
                            break;
                        }
                    
                }
            }
            dataGridView1.DataSource = result;
            this.Text = "Решено ORM";

        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            var count = int.Parse(txtCount.Text);
            task1TA.Fill(ds.Task1, count);
            dataGridView1.DataSource = ds.Task1;
            this.Text = "Решено SQL";
        }
    }
}
