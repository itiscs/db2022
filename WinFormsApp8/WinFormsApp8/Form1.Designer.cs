namespace WinFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvProducts = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edizmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            productsTableAdapter1 = new MyDataSetTableAdapters.ProductsTableAdapter();
            btnSave = new Button();
            dgvCustomers = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customersBindingSource = new BindingSource(components);
            dgvOrders = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            orderdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idprodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idcustDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordersBindingSource = new BindingSource(components);
            customersTableAdapter1 = new MyDataSetTableAdapters.CustomersTableAdapter();
            ordersTableAdapter1 = new MyDataSetTableAdapters.OrdersTableAdapter();
            dateFrom = new DateTimePicker();
            dateTo = new DateTimePicker();
            btnProc = new Button();
            lblResult = new Label();
            menuStrip1 = new MenuStrip();
            формыToolStripMenuItem = new ToolStripMenuItem();
            основнаяToolStripMenuItem = new ToolStripMenuItem();
            альтернативнаяToolStripMenuItem = new ToolStripMenuItem();
            задача1ToolStripMenuItem = new ToolStripMenuItem();
            задача2ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, edizmDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn });
            dgvProducts.DataSource = productsBindingSource;
            dgvProducts.Location = new Point(39, 70);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 92;
            dgvProducts.Size = new Size(1328, 216);
            dgvProducts.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 11;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 225;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 11;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 225;
            // 
            // edizmDataGridViewTextBoxColumn
            // 
            edizmDataGridViewTextBoxColumn.DataPropertyName = "edizm";
            edizmDataGridViewTextBoxColumn.HeaderText = "edizm";
            edizmDataGridViewTextBoxColumn.MinimumWidth = 11;
            edizmDataGridViewTextBoxColumn.Name = "edizmDataGridViewTextBoxColumn";
            edizmDataGridViewTextBoxColumn.Width = 225;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 11;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 225;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "count";
            countDataGridViewTextBoxColumn.HeaderText = "count";
            countDataGridViewTextBoxColumn.MinimumWidth = 11;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 225;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = typeof(MyDataSet);
            // 
            // productsTableAdapter1
            // 
            productsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1571, 758);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 52);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, cityDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn });
            dgvCustomers.DataSource = customersBindingSource;
            dgvCustomers.Location = new Point(43, 315);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 92;
            dgvCustomers.RowTemplate.Height = 45;
            dgvCustomers.Size = new Size(1314, 323);
            dgvCustomers.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            idDataGridViewTextBoxColumn1.HeaderText = "id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 11;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 225;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn1.HeaderText = "name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 11;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 225;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            cityDataGridViewTextBoxColumn.HeaderText = "city";
            cityDataGridViewTextBoxColumn.MinimumWidth = 11;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.Width = 225;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            addressDataGridViewTextBoxColumn.HeaderText = "address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 11;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 225;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 11;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.Width = 225;
            // 
            // customersBindingSource
            // 
            customersBindingSource.DataMember = "Customers";
            customersBindingSource.DataSource = typeof(MyDataSet);
            // 
            // dgvOrders
            // 
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, orderdateDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn1, amountDataGridViewTextBoxColumn, idprodDataGridViewTextBoxColumn, idcustDataGridViewTextBoxColumn });
            dgvOrders.DataSource = ordersBindingSource;
            dgvOrders.Location = new Point(39, 668);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 92;
            dgvOrders.RowTemplate.Height = 45;
            dgvOrders.Size = new Size(1459, 323);
            dgvOrders.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            idDataGridViewTextBoxColumn2.HeaderText = "id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 11;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            idDataGridViewTextBoxColumn2.Width = 225;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            orderdateDataGridViewTextBoxColumn.MinimumWidth = 11;
            orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            orderdateDataGridViewTextBoxColumn.Width = 225;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            countDataGridViewTextBoxColumn1.DataPropertyName = "count";
            countDataGridViewTextBoxColumn1.HeaderText = "count";
            countDataGridViewTextBoxColumn1.MinimumWidth = 11;
            countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            countDataGridViewTextBoxColumn1.Width = 225;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            amountDataGridViewTextBoxColumn.HeaderText = "amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 11;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 225;
            // 
            // idprodDataGridViewTextBoxColumn
            // 
            idprodDataGridViewTextBoxColumn.DataPropertyName = "id_prod";
            idprodDataGridViewTextBoxColumn.HeaderText = "id_prod";
            idprodDataGridViewTextBoxColumn.MinimumWidth = 11;
            idprodDataGridViewTextBoxColumn.Name = "idprodDataGridViewTextBoxColumn";
            idprodDataGridViewTextBoxColumn.Width = 225;
            // 
            // idcustDataGridViewTextBoxColumn
            // 
            idcustDataGridViewTextBoxColumn.DataPropertyName = "id_cust";
            idcustDataGridViewTextBoxColumn.HeaderText = "id_cust";
            idcustDataGridViewTextBoxColumn.MinimumWidth = 11;
            idcustDataGridViewTextBoxColumn.Name = "idcustDataGridViewTextBoxColumn";
            idcustDataGridViewTextBoxColumn.Width = 225;
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataMember = "Orders";
            ordersBindingSource.DataSource = typeof(MyDataSet);
            // 
            // customersTableAdapter1
            // 
            customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // dateFrom
            // 
            dateFrom.Location = new Point(1442, 70);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(450, 43);
            dateFrom.TabIndex = 4;
            dateFrom.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // dateTo
            // 
            dateTo.Location = new Point(1445, 146);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(450, 43);
            dateTo.TabIndex = 5;
            dateTo.Value = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            // 
            // btnProc
            // 
            btnProc.Location = new Point(1581, 234);
            btnProc.Name = "btnProc";
            btnProc.Size = new Size(169, 52);
            btnProc.TabIndex = 6;
            btnProc.Text = "Вычислить";
            btnProc.UseVisualStyleBackColor = true;
            btnProc.Click += btnProc_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(1459, 313);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(141, 37);
            lblResult.TabIndex = 7;
            lblResult.Text = "Результат:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { формыToolStripMenuItem, задача1ToolStripMenuItem, задача2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1929, 47);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            формыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { основнаяToolStripMenuItem, альтернативнаяToolStripMenuItem });
            формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            формыToolStripMenuItem.Size = new Size(129, 43);
            формыToolStripMenuItem.Text = "Формы";
            // 
            // основнаяToolStripMenuItem
            // 
            основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            основнаяToolStripMenuItem.Size = new Size(403, 48);
            основнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            альтернативнаяToolStripMenuItem.Size = new Size(403, 48);
            альтернативнаяToolStripMenuItem.Text = "Альтернативная";
            альтернативнаяToolStripMenuItem.Click += альтернативнаяToolStripMenuItem_Click;
            // 
            // задача1ToolStripMenuItem
            // 
            задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            задача1ToolStripMenuItem.Size = new Size(148, 43);
            задача1ToolStripMenuItem.Text = "Задача 1";
            задача1ToolStripMenuItem.Click += задача1ToolStripMenuItem_Click;
            // 
            // задача2ToolStripMenuItem
            // 
            задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            задача2ToolStripMenuItem.Size = new Size(148, 43);
            задача2ToolStripMenuItem.Text = "Задача 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1929, 1078);
            Controls.Add(lblResult);
            Controls.Add(btnProc);
            Controls.Add(dateTo);
            Controls.Add(dateFrom);
            Controls.Add(dgvOrders);
            Controls.Add(dgvCustomers);
            Controls.Add(btnSave);
            Controls.Add(dgvProducts);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edizmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private BindingSource productsBindingSource;
        private MyDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private Button btnSave;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private BindingSource customersBindingSource;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idprodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idcustDataGridViewTextBoxColumn;
        private BindingSource ordersBindingSource;
        private MyDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private MyDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Button btnProc;
        private Label lblResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem формыToolStripMenuItem;
        private ToolStripMenuItem основнаяToolStripMenuItem;
        private ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private ToolStripMenuItem задача1ToolStripMenuItem;
        private ToolStripMenuItem задача2ToolStripMenuItem;
    }
}