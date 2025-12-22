using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // DB
            Connection con = new Connection();
            con.dataGet("Select * from [User] Where UserName = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt); // fetching data
            if(dt.Rows.Count > 0)
            {
                this.Hide(); // hides Login Form
                frmMain frm = new frmMain();
                frm.Show(); // Main Form pops up 
            }
            else
            {
                MessageBox.Show("Invalid Username & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User.frmChangePassword frm = new User.frmChangePassword();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
