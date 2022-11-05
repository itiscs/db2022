using DbClientApp.MyDataSetTableAdapters;
using System.Data.SqlClient;

namespace DbClientApp
{
    public partial class Form1 : Form
    {
        MyDataSet ds;
        CustomersTableAdapter custAdap;
        public Form1()
        {
            InitializeComponent();
            ds = new MyDataSet();
            custAdap = new CustomersTableAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            custAdap.Fill(ds.Customers);
            productsTableAdapter.Fill(ds.Products);
            ordersTableAdapter.Fill(ds.Orders);
            customersBindingSource.DataSource = ds.Customers;
            productsBindingSource.DataSource = ds.Products; 
            ordersBindingSource.DataSource = ds.Orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            custAdap.Fill(ds.Customers);
            productsTableAdapter.Fill(ds.Products);
            ordersTableAdapter.Fill(ds.Orders);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                custAdap.Update(ds.Customers);
                productsTableAdapter.Update(ds.Products);
                ordersTableAdapter.Update(ds.Orders);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=base012;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Get_prod_amounts";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prod",txtProd.Text);
            cmd.Parameters.AddWithValue("@date1", dateFrom.Value);
            cmd.Parameters.AddWithValue("@date2", dateTo.Value);
            
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@sum";
            param.Direction = System.Data.ParameterDirection.Output;
            param.SqlDbType = System.Data.SqlDbType.Int;
            //param.Size = 15;
            //param.Precision = 2;
            cmd.Parameters.Add(param);

            con.Open();
            cmd.ExecuteNonQuery();
            lblResult.Text = $"Результат: {cmd.Parameters["@sum"].Value}";
            con.Close();


        }
    }
}