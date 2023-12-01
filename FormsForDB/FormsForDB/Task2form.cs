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
    public partial class Task2form : Form
    {
        MyDataSet ds = new MyDataSet();
        Task2TableAdapter adap = new Task2TableAdapter();
        public Task2form()
        {
            InitializeComponent();
        }

        private void Task2form_Load(object sender, EventArgs e)
        {
            adap.Fill(ds.Task2);
            dataGridView1.DataSource = ds.Task2;
        }
    }
}
