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
    public partial class Task1sql : Form
    {
        MyDataSet ds = new MyDataSet();
        Task1TableAdapter adap = new Task1TableAdapter();
        public Task1sql()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            var count = int.Parse(txtCount.Text);
            adap.Fill(ds.Task1, count);
            dataGridView1.DataSource = ds.Task1;
        }
    }
}
