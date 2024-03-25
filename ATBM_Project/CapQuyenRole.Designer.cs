
namespace ATBM_Project
{
    partial class CapQuyenRole
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_CapQuyenUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên role";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cấp quyền SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_CapQuyenUpdate
            // 
            this.button_CapQuyenUpdate.Location = new System.Drawing.Point(20, 152);
            this.button_CapQuyenUpdate.Name = "button_CapQuyenUpdate";
            this.button_CapQuyenUpdate.Size = new System.Drawing.Size(124, 26);
            this.button_CapQuyenUpdate.TabIndex = 3;
            this.button_CapQuyenUpdate.Text = "Cấp quyền UPDATE";
            this.button_CapQuyenUpdate.UseVisualStyleBackColor = true;
            this.button_CapQuyenUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cấp quyền DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cấp quyền INSERT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(158, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 26);
            this.button5.TabIndex = 6;
            this.button5.Text = "Xóa quyền SELECT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(158, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 26);
            this.button6.TabIndex = 7;
            this.button6.Text = "Xóa quyền DELETE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(160, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 26);
            this.button7.TabIndex = 8;
            this.button7.Text = "Xóa quyền INSERT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(158, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 26);
            this.button8.TabIndex = 9;
            this.button8.Text = "Xóa quyền UPDATE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(20, 194);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 31);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // CapQuyenRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 242);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_CapQuyenUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "CapQuyenRole";
            this.Text = "CapQuyenRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_CapQuyenUpdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button_back;
    }
}