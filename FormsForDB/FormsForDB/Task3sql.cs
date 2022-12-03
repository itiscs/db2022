using FormsForDB.MyDataSetTableAdapters;
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
    public partial class Task3sql : Form
    {
        MyDataSet ds = new MyDataSet();
        Task3TableAdapter adap = new Task3TableAdapter();
        public Task3sql()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            var city = txtCity.Text;
            var price = int.Parse(txtPrice.Text);
            var date = dateTo.Value;
            adap.Fill(ds.Task3, city, price, date);
            dataGridView1.DataSource = ds.Task3;
        }
    }
}
