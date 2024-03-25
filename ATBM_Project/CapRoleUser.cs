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
    public partial class CapRoleUser : Form
    {
        MainForm mainForm = null;
        public CapRoleUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.selected_user = "";
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"GRANT {textBox1.Text}  TO {textBox2.Text}";
            OracleCommand cmd = new OracleCommand(query, DangNhap.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Cấp role {textBox1.Text} cho user {textBox2.Text} thành công");
        }
    }
}
