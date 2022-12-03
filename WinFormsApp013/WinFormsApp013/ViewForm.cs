using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp013.MyDataSetTableAdapters;

namespace WinFormsApp013
{
    public partial class ViewForm : Form
    {
        MyDataSet ds = new MyDataSet();
        AllDataTableAdapter viewTA = new AllDataTableAdapter();
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            viewTA.Fill(ds.AllData);
            allDataBindingSource.DataSource = ds.AllData;                

        }
    }
}
