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
    public partial class DangNhap : Form
    {
        public static OracleConnection conn;
        public string connectionString;
        public DangNhap()
        {
            InitializeComponent();
            this.FormClosed += CloseForm;
            textBox2.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connectionString = $@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));Password={textBox2.Text};User ID={textBox1.Text}";
            if (textBox1.Text == "sys" || textBox1.Text == "SYS") connectionString += ";DBA Privilege=SYSDBA";
            conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                   

                }
                
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message);
            }
        }
        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            DangNhap.conn.Close();
        }


    }
}
