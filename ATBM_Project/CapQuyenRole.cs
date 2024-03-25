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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM_Project
{
    public partial class CapQuyenRole : Form
    {
        
        MainForm mainForm = null;
        bool column = false;
        public CapQuyenRole(MainForm MainForm)
        {
            InitializeComponent();
            load_table();
            mainForm = MainForm;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"GRANT UPDATE ON {selectedValue} TO C##{textBox1.Text}";

            if (column == true)
            {
                query = $"GRANT UPDATE ({comboBox2.SelectedItem.ToString()}) ON {selectedValue} TO C##{textBox1.Text}";
                OracleCommand command = new OracleCommand(query, DangNhap.conn);
                command.ExecuteNonQuery();
            }
            else
            {
                OracleCommand command = new OracleCommand(query, DangNhap.conn);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Cấp quyền UPDATE thành công");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string selectedValue = comboBox1.SelectedItem.ToString();
           
            string createViewCommandText = $"CREATE OR REPLACE VIEW v_{selectedValue}_{comboBox2.SelectedItem.ToString()} AS SELECT {comboBox2.SelectedItem.ToString()} FROM {selectedValue}";
            
            string query = $"GRANT SELECT ON {selectedValue} TO {textBox1.Text}";
            if (column == true)
            {
                OracleCommand createViewCommand = new OracleCommand(createViewCommandText, DangNhap.conn);
                createViewCommand.ExecuteNonQuery();
                query = $"GRANT SELECT ON v_{selectedValue}_{comboBox2.SelectedItem.ToString()} TO C##{textBox1.Text}";
                OracleCommand command = new OracleCommand(query, DangNhap.conn);
                command.ExecuteNonQuery();
            }
            else
            {
                OracleCommand command = new OracleCommand(query, DangNhap.conn);
                command.ExecuteNonQuery();
            }
              
            
         

            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền SELECT thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"GRANT DELETE ON {selectedValue} TO C##{textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền DELETE thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"GRANT INSERT ON {selectedValue} TO C##{textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cấp quyền INSERT thành công");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.selected_user = "";
            mainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE SELECT ON {selectedValue} FROM C##{textBox1.Text}";
            if (column == true)
            {
                query = $"REVOKE SELECT ON v_{selectedValue}_{comboBox2.SelectedItem.ToString()} FROM C##{textBox1.Text}";
                OracleCommand command = new OracleCommand(query, DangNhap.conn);
                command.ExecuteNonQuery();
            }
            else
            {
                OracleCommand command = new OracleCommand(query, DangNhap.conn);
                command.ExecuteNonQuery();
            }
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền SELECT thành công");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE DELETE ON {selectedValue} FROM C##{textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền DELETE thành công");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE INSERT ON {selectedValue} FROM C##{textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền INSERT thành công");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = $"REVOKE UPDATE ON {selectedValue} FROM C##{textBox1.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa quyền UPDATE thành công");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            column = !column;
        }
    }
}
