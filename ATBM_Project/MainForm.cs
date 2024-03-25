using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace ATBM_Project
{
    public partial class MainForm : Form
    {
       
        public string selected_user = "";
        
        public string user_or_role = "";
        public MainForm()
        {
            InitializeComponent();
            /*conn = new OracleConnection(connectionString);
            conn.Open();*/
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            this.FormClosed += CloseForm;
            dataGridView1.DataBindingComplete += clear_first_select;
            textBox2.PasswordChar = '*';

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selected_user = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
                if (selected_user != "" && user_or_role == "user")
                {
                    XemQuyen_User xem_quyen = new XemQuyen_User(this);
                    this.Hide();
                    xem_quyen.Location = this.Location;
                    xem_quyen.Show();
                
                }
                if (selected_user != "" && user_or_role == "role")
                {
                    XemQuyen_Role xem_quyen = new XemQuyen_Role(this);
                    this.Hide();
                    xem_quyen.Location = this.Location;
                    xem_quyen.Show();
                }
            

        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            DangNhap.conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            user_or_role = "role";
            LoadData();
            textBox2.Enabled = false;
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_or_role = "user";
            LoadData();
            if (!textBox2.Enabled) textBox2.Enabled = true;
            button5.Enabled = true;
        }

        private void clear_first_select(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
        private void LoadData()
        {
            string cmdstr = "";

            if (user_or_role == "role")
                cmdstr = "SELECT ROLE FROM DBA_ROLES";
            else if (user_or_role == "user")
                cmdstr = "SELECT username FROM all_users";
            OracleCommand cmd = new OracleCommand(cmdstr, DangNhap.conn);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (user_or_role == "user")
            {
                OracleCommand cmd = new OracleCommand($"DROP USER {selected_user} CASCADE", DangNhap.conn);
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("SELECT username FROM all_users", DangNhap.conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (user_or_role == "role")
            {
                OracleCommand cmd = new OracleCommand($"DROP ROLE {selected_user}", DangNhap.conn);
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("SELECT ROLE FROM DBA_ROLES", DangNhap.conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (user_or_role == "user" && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                OracleCommand cmd = new OracleCommand($"CREATE USER C##{textBox1.Text} IDENTIFIED BY {textBox2.Text}", DangNhap.conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                LoadData();
            }
            if (user_or_role == "role" && !String.IsNullOrEmpty(textBox1.Text))
            {
                OracleCommand cmd = new OracleCommand($"CREATE ROLE C##{textBox1.Text}", DangNhap.conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string command = $"alter user C##{textBox1.Text} identified by {textBox2.Text}";
                OracleCommand cmd = new OracleCommand(command, DangNhap.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hieu chinh thanh cong");
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PhanQuyen phan_quyen = new PhanQuyen(this);
            this.Hide();
            phan_quyen.Location = this.Location;
            phan_quyen.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (user_or_role == "user" && selected_user != "")
            {
                OracleCommand cmd = new OracleCommand($"select * from DBA_ROLE_PRIVS where GRANTEE ='{selected_user}'", DangNhap.conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
