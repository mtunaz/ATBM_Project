namespace ATBM_Project
{
    partial class XemQuyen_Role
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
            this.button_PCol = new System.Windows.Forms.Button();
            this.button_PTable = new System.Windows.Forms.Button();
            this.button_PSys = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_PCol
            // 
            this.button_PCol.Location = new System.Drawing.Point(274, 120);
            this.button_PCol.Name = "button_PCol";
            this.button_PCol.Size = new System.Drawing.Size(125, 38);
            this.button_PCol.TabIndex = 9;
            this.button_PCol.Text = "Xem quyền trên cột";
            this.button_PCol.UseVisualStyleBackColor = true;
            this.button_PCol.Click += new System.EventHandler(this.button_PCol_Click_1);
            // 
            // button_PTable
            // 
            this.button_PTable.Location = new System.Drawing.Point(143, 120);
            this.button_PTable.Name = "button_PTable";
            this.button_PTable.Size = new System.Drawing.Size(125, 38);
            this.button_PTable.TabIndex = 8;
            this.button_PTable.Text = "Xem quyền trên bảng";
            this.button_PTable.UseVisualStyleBackColor = true;
            this.button_PTable.Click += new System.EventHandler(this.button_PTable_Click_1);
            // 
            // button_PSys
            // 
            this.button_PSys.Location = new System.Drawing.Point(12, 122);
            this.button_PSys.Name = "button_PSys";
            this.button_PSys.Size = new System.Drawing.Size(125, 36);
            this.button_PSys.TabIndex = 7;
            this.button_PSys.Text = "Xem quyền hệ thống";
            this.button_PSys.UseVisualStyleBackColor = true;
            this.button_PSys.Click += new System.EventHandler(this.button_PSys_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(23, 16);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 31);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 274);
            this.dataGridView1.TabIndex = 5;
            // 
            // XemQuyen_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_PCol);
            this.Controls.Add(this.button_PTable);
            this.Controls.Add(this.button_PSys);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XemQuyen_Role";
            this.Text = "XemQuyen_Role";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PCol;
        private System.Windows.Forms.Button button_PTable;
        private System.Windows.Forms.Button button_PSys;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}