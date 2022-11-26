namespace WinFormsApp013
{
    partial class Task1Form
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
            this.btnORM = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnORM
            // 
            this.btnORM.Location = new System.Drawing.Point(684, 436);
            this.btnORM.Name = "btnORM";
            this.btnORM.Size = new System.Drawing.Size(150, 46);
            this.btnORM.TabIndex = 11;
            this.btnORM.Text = "ORM";
            this.btnORM.UseVisualStyleBackColor = true;
            this.btnORM.Click += new System.EventHandler(this.btnORM_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(449, 436);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(172, 46);
            this.btnSQL.TabIndex = 10;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(918, 364);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(223, 440);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(200, 39);
            this.txtCount.TabIndex = 12;
            this.txtCount.Text = "0";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество:";
            // 
            // Task1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnORM);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Task1Form";
            this.Text = "Task1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnORM;
        private Button btnSQL;
        private DataGridView dataGridView1;
        private TextBox txtCount;
        private Label label1;
    }
}