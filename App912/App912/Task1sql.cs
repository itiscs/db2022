using App912.DataSet912TableAdapters;
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
    public partial class Task1sql : Form
    {
        DataSet912 ds = new DataSet912();   
        Task1TableAdapter adap = new Task1TableAdapter();
        public Task1sql()
        {
            InitializeComponent();
        }

        private void Task1sql_Load(object sender, EventArgs e)
        {

        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            var count = int.Parse(txtCount.Text);
            adap.Fill(ds.Task1, count);
            dataGridView1.DataSource = ds.Task1;
        }
    }
}
