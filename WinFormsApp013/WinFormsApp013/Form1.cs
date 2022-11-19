using System.Data.SqlClient;
using WinFormsApp013.MyDataSetTableAdapters;

namespace WinFormsApp013
{
    public partial class Form1 : Form
    {
        MyDataSet ds = new MyDataSet();
        ProductsTableAdapter prodTA = new ProductsTableAdapter();
        CustomersTableAdapter custTA = new CustomersTableAdapter(); 
        OrdersTableAdapter ordersTA = new OrdersTableAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prodTA.Fill(ds.Products);
            custTA.Fill(ds.Customers);
            ordersTA.Fill(ds.Orders);
            productsBindingSource.DataSource = ds.Products;
            ordersBindingSource.DataSource = ds.Orders;
            customersBindingSource.DataSource = ds.Customers;   
        }

        private void ‡Î¸ÚÂÌ‡ÚË‚Ì‡ˇ‘ÓÏ‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            //string prod = prodGrid.CurrentRow.Cells[1].Value.ToString();
            string prod = prodGrid.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();

            

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=base013;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Get_prod_amounts";
            cmd.Parameters.AddWithValue("@prod", prod);
            cmd.Parameters.AddWithValue("@date1", dateFrom.Value);
            cmd.Parameters.AddWithValue("@date2", dateTo.Value);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@sum";
            param.Direction = System.Data.ParameterDirection.Output;
            param.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(param);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            var res = cmd.Parameters["@sum"].Value.ToString();
            lblResult.Text = $"—ÛÏÏ‡ = {res}";
        }
    }
}