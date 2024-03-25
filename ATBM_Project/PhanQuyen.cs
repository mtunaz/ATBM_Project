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
    public partial class PhanQuyen : Form
    {
        MainForm mainForm = null;
        public PhanQuyen(MainForm main_form)
        {
            InitializeComponent();
            mainForm = main_form;
            this.FormClosed += CloseForm;

        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            DangNhap.conn.Close();
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cấp quyền cho user")
            {
                CapQuyenUser cap_quyen_user = new CapQuyenUser(mainForm);
                this.Hide();
                cap_quyen_user.Location = this.Location;
                cap_quyen_user.Show();
            }    else
            if (comboBox1.Text == "Cấp quyền cho role")
            {
                CapQuyenRole cap_quyen_role = new CapQuyenRole(mainForm);
                this.Hide();
                cap_quyen_role.Location = this.Location;
                cap_quyen_role.Show();
            } else
            if (comboBox1.Text == "Cấp role cho user")
            {
                CapRoleUser cap_role_user = new CapRoleUser(mainForm);
                this.Hide();
                cap_role_user.Location = this.Location;
                cap_role_user.Show();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
