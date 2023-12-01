namespace WinFormsApp8
{
    partial class Zadacha1
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
            label1 = new Label();
            txtKol = new TextBox();
            btnSQL = new Button();
            btnORM = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(1233, 424);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 471);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 1;
            label1.Text = "Количество:";
            // 
            // txtKol
            // 
            txtKol.Location = new Point(484, 471);
            txtKol.Name = "txtKol";
            txtKol.Size = new Size(180, 43);
            txtKol.TabIndex = 2;
            txtKol.Text = "0";
            txtKol.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSQL
            // 
            btnSQL.Location = new Point(269, 561);
            btnSQL.Name = "btnSQL";
            btnSQL.Size = new Size(169, 52);
            btnSQL.TabIndex = 3;
            btnSQL.Text = "SQL";
            btnSQL.UseVisualStyleBackColor = true;
            btnSQL.Click += btnSQL_Click;
            // 
            // btnORM
            // 
            btnORM.Location = new Point(650, 561);
            btnORM.Name = "btnORM";
            btnORM.Size = new Size(169, 52);
            btnORM.TabIndex = 4;
            btnORM.Text = "ORM";
            btnORM.UseVisualStyleBackColor = true;
            btnORM.Click += btnORM_Click;
            // 
            // Zadacha1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 815);
            Controls.Add(btnORM);
            Controls.Add(btnSQL);
            Controls.Add(txtKol);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Zadacha1";
            Text = "Zadacha1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtKol;
        private Button btnSQL;
        private Button btnORM;
    }
}