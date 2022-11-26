namespace App912
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(108, 438);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(150, 46);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(470, 438);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(150, 46);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(874, 438);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(150, 46);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(470, 556);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(150, 46);
            this.btnTask1.TabIndex = 4;
            this.btnTask1.Text = "Задача 1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(219, 556);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(200, 39);
            this.txtCount.TabIndex = 5;
            this.txtCount.Text = "0";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 701);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnTask1);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnProducts;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnTask1;
        private TextBox txtCount;
    }
}