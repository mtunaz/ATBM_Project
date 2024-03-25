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
        bool with_grant_option = false;
        string withgo = " WITH GRANT OPTION";
        public CapQuyenUser(MainForm MainForm)
        {

            InitializeComponent();
            load_table();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            mainForm = MainForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tableName = comboBox1.SelectedItem.ToString();
            OracleCommand cmd = new OracleCommand($"SELECT column_name FROM all_tab_columns WHERE table_name = '{tableName}'", DangNhap.conn);
            OracleDataReader reader = cmd.ExecuteReader();

            // Clear the ComboBox and add the column names
            comboBox2.Items.Clear();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString(0));
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"GRANT SELECT ON {selectedValue} TO {textBox1.Text}";
            if (with_grant_option == true) query += withgo;
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền SELECT thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"GRANT DELETE ON {selectedValue} TO {textBox1.Text}";
            if (with_grant_option == true) query += withgo;
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền DELETE thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"GRANT INSERT ON {selectedValue} TO {textBox1.Text}";
            if (with_grant_option == true) query += withgo;
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền INSERT thành công");
        }

        private void button_CapQuyenUpdate_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"GRANT UPDATE ON {selectedValue} TO {textBox1.Text}";
            if (with_grant_option == true) query += withgo;
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền UPDATE thành công");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE SELECT ON {selectedValue} FROM {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền SELECT thành công");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE DELETE ON {selectedValue} FROM {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền DELETE thành công");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE INSERT ON {selectedValue} FROM {textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền INSERT thành công");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE UPDATE ON {selectedValue} FROM {textBox1.Text}";
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
        private void load_table()
        {
            OracleCommand cmd = new OracleCommand("SELECT table_name FROM all_tables", DangNhap.conn);
            OracleDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            with_grant_option = !with_grant_option;
        }
    }
}
