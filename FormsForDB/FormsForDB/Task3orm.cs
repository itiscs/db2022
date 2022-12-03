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
    public partial class Task3orm : Form
    {
        MyBaseContext db = new MyBaseContext();
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
                // если другой город переходим к следующему покупателю
                
                allProd = true;
                foreach(var p in db.Products.ToList())
                {
                    if (p.Price <= price)
                        continue;
                    //цена меньше заданной переходим к следующему товару

                    exOrder = false;
                    foreach(var o in db.Orders.ToList())
                    {
                        if(o.IdCust == c.Id && o.IdProd == p.Id
                            && o.Orderdate < date)
                        {
                            exOrder = true;//нашли подходящий заказ
                            break;
                        }
                    }
                    if(!exOrder)
                    {
                        allProd = false;//нет ни одного заказа подходящего товара
                        break;
                    }
                }
                if(allProd)
                {
                    // у всех товаров с ценой больше заданой есть заказы
                    lst.Add(new Task3() { Name = c.Name });
                }
            }
            dataGridView1.DataSource = lst;
        }
    }
}
