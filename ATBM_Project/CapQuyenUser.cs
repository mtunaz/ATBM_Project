using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ATBM_Project
{
    public partial class CapQuyenUser : Form
    {
        MainForm mainForm = null;
        public CapQuyenUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"GRANT SELECT ANY TABLE TO {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền SELECT thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = $"GRANT DELETE ANY TABLE TO {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền DELETE thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = $"GRANT INSERT ANY TABLE TO {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền INSERT thành công");
        }

        private void button_CapQuyenUpdate_Click(object sender, EventArgs e)
        {
            string query = $"GRANT UPDATE ANY TABLE TO {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền UPDATE thành công");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = $"REVOKE SELECT ANY TABLE FROM {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền SELECT thành công");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = $"REVOKE DELETE ANY TABLE FROM {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền DELETE thành công");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = $"REVOKE INSERT ANY TABLE FROM {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền INSERT thành công");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = $"REVOKE UPDATE ANY TABLE FROM {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền UPDATE thành công");
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.selected_user = "";
            mainForm.Show();
        }
    }
}
