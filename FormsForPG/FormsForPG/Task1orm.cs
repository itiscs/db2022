using FormsForPG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsForPG
{
    public partial class Task1orm : Form
    {
        MyBaseContext db = new MyBaseContext();
        public Task1orm()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            List<Task1> lst = new List<Task1>();
            var count = int.Parse(txtCount.Text);

            foreach (var o in db.Orders.ToList())
            {
                if (o.Count <= count)
                    continue;
                foreach (var p in db.Products.ToList())
                {
                    if (p.IdProd == o.IdProd)
                    {
                        Task1 t1 = new Task1();
                        t1.Name = p.Name;
                        t1.Orderdate = o.DateOrder;
                        t1.Count = o.Count;
                        t1.Price = p.Price;
                        t1.Amount = o.Amount;
                        lst.Add(t1);
                        break;
                    }
                }
            }
            dataGridView1.DataSource = lst;


        }
    }
}
