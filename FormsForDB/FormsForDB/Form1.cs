using FormsForDB.MyDataSetTableAdapters;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FormsForDB
{
    public partial class Form1 : Form
    {
        MyDataSet ds = new MyDataSet(); 
        CustomersTableAdapter custTA = new CustomersTableAdapter();
        ProductsTableAdapter prodTA = new ProductsTableAdapter();
        OrdersTableAdapter ordTA = new OrdersTableAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void FillData()
        {
            custTA.Fill(ds.Customers);
            prodTA.Fill(ds.Products);
            ordTA.Fill(ds.Orders);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();
            customersBindingSource.DataSource = ds.Customers;
            productsBindingSource.DataSource = ds.Products;
            ordersBindingSource.DataSource = ds.Orders;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            ordersDataGridView.CurrentCell = ordersDataGridView[
                ordersDataGridView.CurrentCell.ColumnIndex, 0];    
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            var nRow = ordersDataGridView.CurrentCell.RowIndex;
            var nCol = ordersDataGridView.CurrentCell.ColumnIndex;

            if (nRow > 0)
                ordersDataGridView.CurrentCell = ordersDataGridView[nCol, --nRow];

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var nRow = ordersDataGridView.CurrentCell.RowIndex;
            var nCol = ordersDataGridView.CurrentCell.ColumnIndex;
            
            if (nRow < ordersDataGridView.RowCount - 1)
                ordersDataGridView.CurrentCell = ordersDataGridView[nCol, ++nRow];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ordersDataGridView.CurrentCell = ordersDataGridView[
                    ordersDataGridView.CurrentCell.ColumnIndex, 
                    ordersDataGridView.RowCount - 1];

        }

        private void ordersDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentCell != null)
            { //если существует выбранная ячейка
                int nRow = ordersDataGridView.CurrentCell.RowIndex;
                //первая строка
                if (nRow == 0)
                {
                    btnPrev.Enabled = false;
                    btnFirst.Enabled = false;
                }
                else
                {
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                }
                //последняя строка
                if (nRow == ordersDataGridView.RowCount - 1)
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            custTA.Update(ds.Customers);
            prodTA.Update(ds.Products);
            ordTA.Update(ds.Orders);
            MessageBox.Show("Изменения сохранены!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            try
            {
                var tovar = productsDataGridView.CurrentRow.
                    Cells["nameDataGridViewTextBoxColumn1"].Value.ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.myBaseConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Get_prod_amounts";

                SqlParameter param = new SqlParameter("@sum", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.Parameters.AddWithValue("@prod", tovar);
                cmd.Parameters.AddWithValue("@date1", dateFrom.Value);
                cmd.Parameters.AddWithValue("@date2", dateTo.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                var result = cmd.Parameters["@sum"].Value.ToString();              
                lblResult.Text = tovar + " проданы на сумму " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltForm af = new AltForm();
            af.ShowDialog();
        }

        private void oRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrmForm ormForm = new OrmForm();
            ormForm.ShowDialog();
        }

        private void customersDataGridView_Click(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = customersBindingSource;
            productsDataGridView.DataSource = productsBindingSource;
            ordersDataGridView.DataSource = fkordcustBindingSource;
        }

        private void productsDataGridView_Click(object sender, EventArgs e)
        {
            productsDataGridView.DataSource = productsBindingSource;
            customersDataGridView.DataSource = customersBindingSource;
            ordersDataGridView.DataSource = fkordprodBindingSource;
        }

        private void ordersDataGridView_Click(object sender, EventArgs e)
        {
            ordersDataGridView.DataSource = ordersBindingSource;
            customersDataGridView.DataSource = ordersCustomersBindingSource;
            productsDataGridView.DataSource = ordersProductsBindingSource; 
        }

        private void ordersDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (ordersDataGridView.Columns[e.ColumnIndex].HeaderText == "Количество" ||
                ordersDataGridView.Columns[e.ColumnIndex].Name == "Product")
            {
                //получение кода товара в таблице RASXOD
                var idProd = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells["Product"].Value);
                
                //Поиск цены товара в таблице Товары по коду товара
                var price = ds.Products.FindByid(idProd).price;
                var count = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex]
                    .Cells["countDataGridViewTextBoxColumn1"].Value);
                
                //Вычисление нового значения стоимости
                ordersDataGridView.Rows[e.RowIndex].Cells["amountDataGridViewTextBoxColumn"].Value = 
                      price * count;
            }
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1sql f = new Task1sql();
            f.ShowDialog();
        }

        private void oRMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task1orm f = new Task1orm();
            f.ShowDialog();
        }

        private void sqlCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1cmd f = new Task1cmd();
            f.ShowDialog();
        }

        private void sQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task3sql f = new Task3sql();
            f.ShowDialog();
        }

        private void oRMToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Task3orm f = new Task3orm();
            f.ShowDialog();
        }

        private void sQLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Task2form f = new Task2form();
            f.ShowDialog();
        }

        private void ordersDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (ordersDataGridView.Columns[e.ColumnIndex].HeaderText == "Количество")
                    if (Convert.ToInt32(e.FormattedValue) <= 0)
                        throw new Exception("Количество должно быть положительным");
            }
            catch (Exception a)
            {
                e.Cancel = true;
                MessageBox.Show(a.Message);
                ordersDataGridView.Rows[e.RowIndex].ErrorText = a.Message;
            }
        }
    }
}
