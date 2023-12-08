using System.Data.SqlClient;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        MyDataSet ds = new MyDataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(ds.Products);
            customersTableAdapter1.Fill(ds.Customers);
            ordersTableAdapter1.Fill(ds.Orders);

            productsBindingSource.DataSource = ds.Products;
            customersBindingSource.DataSource = ds.Customers;
            ordersBindingSource.DataSource = ds.Orders;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                productsTableAdapter1.Update(ds.Products);
                customersTableAdapter1.Update(ds.Customers);
                ordersTableAdapter1.Update(ds.Orders);
                MessageBox.Show("Changes saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            try
            {
                var prod = dgvProducts.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myBase113;Integrated Security=True");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Get_Prod_Sum";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dateFrom", dateFrom.Value);
                cmd.Parameters.AddWithValue("@dateTo", dateTo.Value);
                cmd.Parameters.AddWithValue("@product", prod);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@sum";
                param.Direction = System.Data.ParameterDirection.Output;
                param.DbType = System.Data.DbType.Decimal;
                cmd.Parameters.Add(param);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                var res = cmd.Parameters["@sum"].Value.ToString();
                lblResult.Text = $"–ÂÁÛÎ¸Ú‡Ú: {res}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ‡Î¸ÚÂÌ‡ÚË‚Ì‡ˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltForm f = new AltForm();
            f.ShowDialog();
        }

        private void Á‡‰‡˜‡1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1 f = new Zadacha1();
            f.ShowDialog();
        }

        private void Á‡‰‡˜‡3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha3 f = new Zadacha3();
            f.ShowDialog();
        }
    }
}