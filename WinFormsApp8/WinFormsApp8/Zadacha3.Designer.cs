namespace WinFormsApp8
{
    partial class Zadacha3
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
            btnORM = new Button();
            btnSQL = new Button();
            txtCity = new TextBox();
            label1 = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(666, 481);
            dataGridView1.TabIndex = 0;
            // 
            // btnORM
            // 
            btnORM.Location = new Point(1143, 441);
            btnORM.Name = "btnORM";
            btnORM.Size = new Size(169, 52);
            btnORM.TabIndex = 8;
            btnORM.Text = "ORM";
            btnORM.UseVisualStyleBackColor = true;
            btnORM.Click += btnORM_Click;
            // 
            // btnSQL
            // 
            btnSQL.Location = new Point(762, 441);
            btnSQL.Name = "btnSQL";
            btnSQL.Size = new Size(169, 52);
            btnSQL.TabIndex = 7;
            btnSQL.Text = "SQL";
            btnSQL.UseVisualStyleBackColor = true;
            btnSQL.Click += btnSQL_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(989, 114);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(180, 43);
            txtCity.TabIndex = 6;
            txtCity.Text = "Казань";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(807, 114);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 5;
            label1.Text = "Город:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(989, 184);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 43);
            txtPrice.TabIndex = 10;
            txtPrice.Text = "100";
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(807, 184);
            label2.Name = "label2";
            label2.Size = new Size(87, 37);
            label2.TabIndex = 9;
            label2.Text = "Цена:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(807, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(388, 43);
            dateTimePicker1.TabIndex = 11;
            // 
            // Zadacha3
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 919);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(btnORM);
            Controls.Add(btnSQL);
            Controls.Add(txtCity);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Zadacha3";
            Text = "Zadacha3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnORM;
        private Button btnSQL;
        private TextBox txtCity;
        private Label label1;
        private TextBox txtPrice;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}