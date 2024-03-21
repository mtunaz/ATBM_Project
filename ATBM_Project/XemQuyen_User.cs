using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Oracle.DataAccess.Client;

namespace ATBM_Project
{
    public partial class XemQuyen_User : Form
    {
       
        MainForm mainForm = null;
        public XemQuyen_User(MainForm main_form)
        {
            InitializeComponent();
            mainForm = main_form;
            this.FormClosed += CloseForm;

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM user_sys_privs WHERE username = '{mainForm.selected_user}'";
            OracleCommand cmd = new OracleCommand(query, MainForm.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_PTable_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = '{mainForm.selected_user}'";
            OracleCommand cmd = new OracleCommand(query, MainForm.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CloseForm (object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            MainForm.conn.Close();
        }

        private void button_PCol_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM USER_COL_PRIVS WHERE GRANTEE = '{mainForm.selected_user}'";
            OracleCommand cmd = new OracleCommand(query, MainForm.conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void XemQuyen_User_Load(object sender, EventArgs e)
        {

        }

        
    }
}
