namespace FormsForDB
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
            this.components = new System.ComponentModel.Container();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edizmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.btnProc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oRMToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fkordcustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkordprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fkordcustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkordprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(12, 56);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 82;
            this.customersDataGridView.RowTemplate.Height = 41;
            this.customersDataGridView.Size = new System.Drawing.Size(919, 218);
            this.customersDataGridView.TabIndex = 0;
            this.customersDataGridView.Click += new System.EventHandler(this.customersDataGridView_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = typeof(FormsForDB.MyDataSet);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.edizmDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 292);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 82;
            this.productsDataGridView.RowTemplate.Height = 41;
            this.productsDataGridView.Size = new System.Drawing.Size(919, 276);
            this.productsDataGridView.TabIndex = 1;
            this.productsDataGridView.Click += new System.EventHandler(this.productsDataGridView_Click);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // edizmDataGridViewTextBoxColumn
            // 
            this.edizmDataGridViewTextBoxColumn.DataPropertyName = "ed_izm";
            this.edizmDataGridViewTextBoxColumn.HeaderText = "Ед.изм.";
            this.edizmDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.edizmDataGridViewTextBoxColumn.Name = "edizmDataGridViewTextBoxColumn";
            this.edizmDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 200;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = typeof(FormsForDB.MyDataSet);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderdateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn,
            this.Product,
            this.Customer});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(14, 579);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 82;
            this.ordersDataGridView.RowTemplate.Height = 41;
            this.ordersDataGridView.Size = new System.Drawing.Size(1289, 280);
            this.ordersDataGridView.TabIndex = 2;
            this.ordersDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ordersDataGridView_CellValidating);
            this.ordersDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellValueChanged);
            this.ordersDataGridView.CurrentCellChanged += new System.EventHandler(this.ordersDataGridView_CurrentCellChanged);
            this.ordersDataGridView.Click += new System.EventHandler(this.ordersDataGridView_Click);
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "orderdate";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.orderdateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 200;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "id_prod";
            this.Product.DataSource = this.productsBindingSource;
            this.Product.DisplayMember = "name";
            this.Product.HeaderText = "Товар";
            this.Product.MinimumWidth = 10;
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Product.ValueMember = "id";
            this.Product.Width = 200;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "id_cust";
            this.Customer.DataSource = this.customersBindingSource;
            this.Customer.DisplayMember = "name";
            this.Customer.HeaderText = "Покупатель";
            this.Customer.MinimumWidth = 10;
            this.Customer.Name = "Customer";
            this.Customer.ValueMember = "id";
            this.Customer.Width = 200;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = typeof(FormsForDB.MyDataSet);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(137, 877);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(150, 46);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "Первая";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(311, 877);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(169, 46);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(510, 878);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 46);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(697, 878);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(150, 46);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = "Последняя";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(869, 879);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1039, 879);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 46);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(977, 56);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(285, 39);
            this.dateFrom.TabIndex = 9;
            this.dateFrom.Value = new System.DateTime(2022, 1, 1, 18, 42, 0, 0);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(977, 122);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(285, 39);
            this.dateTo.TabIndex = 10;
            this.dateTo.Value = new System.DateTime(2022, 12, 31, 18, 43, 0, 0);
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(996, 193);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(250, 46);
            this.btnProc.TabIndex = 11;
            this.btnProc.Text = "Вызов процедуры";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(973, 271);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(252, 32);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Результат процедуры";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem,
            this.задача1ToolStripMenuItem,
            this.задача2ToolStripMenuItem,
            this.задача3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1381, 40);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаяToolStripMenuItem,
            this.альтернативнаяToolStripMenuItem,
            this.oRMToolStripMenuItem});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // основнаяToolStripMenuItem
            // 
            this.основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            this.основнаяToolStripMenuItem.Size = new System.Drawing.Size(325, 44);
            this.основнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            this.альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            this.альтернативнаяToolStripMenuItem.Size = new System.Drawing.Size(325, 44);
            this.альтернативнаяToolStripMenuItem.Text = "Альтернативная";
            this.альтернативнаяToolStripMenuItem.Click += new System.EventHandler(this.альтернативнаяToolStripMenuItem_Click);
            // 
            // oRMToolStripMenuItem
            // 
            this.oRMToolStripMenuItem.Name = "oRMToolStripMenuItem";
            this.oRMToolStripMenuItem.Size = new System.Drawing.Size(325, 44);
            this.oRMToolStripMenuItem.Text = "ORM";
            this.oRMToolStripMenuItem.Click += new System.EventHandler(this.oRMToolStripMenuItem_Click);
            // 
            // задача1ToolStripMenuItem
            // 
            this.задача1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem,
            this.oRMToolStripMenuItem1,
            this.sqlCommandToolStripMenuItem});
            this.задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            this.задача1ToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.задача1ToolStripMenuItem.Text = "Задача 1";
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // oRMToolStripMenuItem1
            // 
            this.oRMToolStripMenuItem1.Name = "oRMToolStripMenuItem1";
            this.oRMToolStripMenuItem1.Size = new System.Drawing.Size(291, 44);
            this.oRMToolStripMenuItem1.Text = "ORM";
            this.oRMToolStripMenuItem1.Click += new System.EventHandler(this.oRMToolStripMenuItem1_Click);
            // 
            // sqlCommandToolStripMenuItem
            // 
            this.sqlCommandToolStripMenuItem.Name = "sqlCommandToolStripMenuItem";
            this.sqlCommandToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
            this.sqlCommandToolStripMenuItem.Text = "SqlCommand";
            this.sqlCommandToolStripMenuItem.Click += new System.EventHandler(this.sqlCommandToolStripMenuItem_Click);
            // 
            // задача2ToolStripMenuItem
            // 
            this.задача2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem2});
            this.задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            this.задача2ToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.задача2ToolStripMenuItem.Text = "Задача 2";
            // 
            // sQLToolStripMenuItem2
            // 
            this.sQLToolStripMenuItem2.Name = "sQLToolStripMenuItem2";
            this.sQLToolStripMenuItem2.Size = new System.Drawing.Size(189, 44);
            this.sQLToolStripMenuItem2.Text = "SQL";
            this.sQLToolStripMenuItem2.Click += new System.EventHandler(this.sQLToolStripMenuItem2_Click);
            // 
            // задача3ToolStripMenuItem
            // 
            this.задача3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem1,
            this.oRMToolStripMenuItem2});
            this.задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            this.задача3ToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.задача3ToolStripMenuItem.Text = "Задача 3";
            // 
            // sQLToolStripMenuItem1
            // 
            this.sQLToolStripMenuItem1.Name = "sQLToolStripMenuItem1";
            this.sQLToolStripMenuItem1.Size = new System.Drawing.Size(201, 44);
            this.sQLToolStripMenuItem1.Text = "SQL";
            this.sQLToolStripMenuItem1.Click += new System.EventHandler(this.sQLToolStripMenuItem1_Click);
            // 
            // oRMToolStripMenuItem2
            // 
            this.oRMToolStripMenuItem2.Name = "oRMToolStripMenuItem2";
            this.oRMToolStripMenuItem2.Size = new System.Drawing.Size(201, 44);
            this.oRMToolStripMenuItem2.Text = "ORM";
            this.oRMToolStripMenuItem2.Click += new System.EventHandler(this.oRMToolStripMenuItem2_Click);
            // 
            // fkordcustBindingSource
            // 
            this.fkordcustBindingSource.DataMember = "fk_ord_cust";
            this.fkordcustBindingSource.DataSource = this.customersBindingSource;
            // 
            // fkordprodBindingSource
            // 
            this.fkordprodBindingSource.DataMember = "fk_ord_prod";
            this.fkordprodBindingSource.DataSource = this.productsBindingSource;
            // 
            // ordersCustomersBindingSource
            // 
            this.ordersCustomersBindingSource.DataMember = "Orders_Customers";
            this.ordersCustomersBindingSource.DataSource = this.ordersBindingSource;
            // 
            // ordersProductsBindingSource
            // 
            this.ordersProductsBindingSource.DataMember = "Orders_Products";
            this.ordersProductsBindingSource.DataSource = this.ordersBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 937);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fkordcustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkordprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView customersDataGridView;
        private BindingSource customersBindingSource;
        private DataGridView productsDataGridView;
        private BindingSource productsBindingSource;
        private DataGridView ordersDataGridView;
        private BindingSource ordersBindingSource;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private Button btnSave;
        private Button btnRefresh;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Button btnProc;
        private Label lblResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem формыToolStripMenuItem;
        private ToolStripMenuItem основнаяToolStripMenuItem;
        private ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private ToolStripMenuItem oRMToolStripMenuItem;
        private ToolStripMenuItem задача1ToolStripMenuItem;
        private BindingSource fkordcustBindingSource;
        private BindingSource fkordprodBindingSource;
        private BindingSource ordersCustomersBindingSource;
        private BindingSource ordersProductsBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn edizmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Product;
        private DataGridViewComboBoxColumn Customer;
        private ToolStripMenuItem sQLToolStripMenuItem;
        private ToolStripMenuItem oRMToolStripMenuItem1;
        private ToolStripMenuItem sqlCommandToolStripMenuItem;
        private ToolStripMenuItem задача2ToolStripMenuItem;
        private ToolStripMenuItem задача3ToolStripMenuItem;
        private ToolStripMenuItem sQLToolStripMenuItem1;
        private ToolStripMenuItem oRMToolStripMenuItem2;
        private ToolStripMenuItem sQLToolStripMenuItem2;
    }
}