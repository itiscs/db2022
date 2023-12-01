namespace WinFormsApp8
{
    partial class AltForm
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
            dataGridView1 = new DataGridView();
            btnProd = new Button();
            btnCust = new Button();
            btnOrders = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(1171, 470);
            dataGridView1.TabIndex = 0;
            // 
            // btnProd
            // 
            btnProd.Location = new Point(187, 590);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(169, 52);
            btnProd.TabIndex = 1;
            btnProd.Text = "Products";
            btnProd.UseVisualStyleBackColor = true;
            btnProd.Click += btnProd_Click;
            // 
            // btnCust
            // 
            btnCust.Location = new Point(487, 590);
            btnCust.Name = "btnCust";
            btnCust.Size = new Size(169, 52);
            btnCust.TabIndex = 2;
            btnCust.Text = "Customers";
            btnCust.UseVisualStyleBackColor = true;
            btnCust.Click += btnCust_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(798, 590);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(169, 52);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // AltForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 832);
            Controls.Add(btnOrders);
            Controls.Add(btnCust);
            Controls.Add(btnProd);
            Controls.Add(dataGridView1);
            Name = "AltForm";
            Text = "AltForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnProd;
        private Button btnCust;
        private Button btnOrders;
    }
}