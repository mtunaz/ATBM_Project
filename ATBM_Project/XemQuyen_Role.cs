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
    public partial class XemQuyen_Role : Form
    {
        MainForm mainForm = null;
        public XemQuyen_Role(MainForm main_form)
        {
            InitializeComponent();
            mainForm = main_form;
            this.FormClosed += CloseForm;

        }


        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            MainForm.conn.Close();
        }

  
        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.selected_user = "";
            mainForm.Show();

        }

        private void button_PSys_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM ROLE_SYS_PRIVS WHERE ROLE = '{mainForm.selected_user}'";
            OracleCommand cmd = new OracleCommand(query, MainForm.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_PTable_Click_1(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE = '{mainForm.selected_user}'";
            OracleCommand cmd = new OracleCommand(query, MainForm.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_PCol_Click_1(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM USER_COL_PRIVS WHERE GRANTEE = '{mainForm.selected_user}'";
            OracleCommand cmd = new OracleCommand(query, MainForm.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
