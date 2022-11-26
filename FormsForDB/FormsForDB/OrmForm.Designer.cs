namespace FormsForDB
{
    partial class OrmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableName.Location = new System.Drawing.Point(472, 450);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(149, 45);
            this.lblTableName.TabIndex = 11;
            this.lblTableName.Text = "Таблица";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(839, 517);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(155, 46);
            this.btnOrders.TabIndex = 10;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(465, 517);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(150, 46);
            this.btnProducts.TabIndex = 9;
            this.btnProducts.Text = "Товары";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(50, 517);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(161, 46);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "Покупатели";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 422);
            this.dataGridView1.TabIndex = 7;
            // 
            // OrmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 664);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrmForm";
            this.Text = "OrmForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTableName;
        private Button btnOrders;
        private Button btnProducts;
        private Button btnCustomers;
        private DataGridView dataGridView1;
    }
}