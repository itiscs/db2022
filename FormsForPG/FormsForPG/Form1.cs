using FormsForPG.myDataSetTableAdapters;
using Npgsql;

namespace FormsForPG
{
    public partial class Form1 : Form
    {
        myDataSet ds = new myDataSet();
        CustomersTableAdapter custTA = new CustomersTableAdapter();
        ProductsTableAdapter prodTA = new ProductsTableAdapter();
        OrdersTableAdapter ordTA = new OrdersTableAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            custTA.Fill(ds.Customers);
            prodTA.Fill(ds.Products);
            ordTA.Fill(ds.Orders);
            customersBindingSource.DataSource = ds.Customers;
            productsBindingSource.DataSource = ds.Products;
            ordersBindingSource.DataSource = ds.Orders;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            custTA.Update(ds.Customers);
            prodTA.Update(ds.Products);
            ordTA.Update(ds.Orders);
            MessageBox.Show("OK");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds.Orders.Clear();
            custTA.Fill(ds.Customers);
            prodTA.Fill(ds.Products);
            ordTA.Fill(ds.Orders);
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            try
            {
                var prod = productsDataGridView.CurrentRow.Cells["nameDataGridViewTextBoxColumn1"].Value.ToString();
                NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1;Persist Security Info=True;Database=myBase");
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                var cmdText = $"select get_prod_sum_f('{prod}','{dateFrom.Value}'," +
                    $"'{dateTo.Value}')";
                cmd.CommandText = cmdText;

                con.Open();
                var x = cmd.ExecuteScalar();
                con.Close();
                
                lblResult.Text = $"—ÛÏÏ‡ = {x}";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1sql f = new Task1sql();
            f.ShowDialog();
        }

        private void oRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1orm f = new Task1orm();
            f.ShowDialog();
        }

        private void sqlCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1cmd f = new Task1cmd();
            f.ShowDialog();
        }
    }
}