using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.User
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtUserName.Text.Length > 0)
                {
                    txtOldPassword.Focus();
                }
                else
                {
                    txtUserName.Focus();
                }
            }
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtOldPassword.Text.Length > 0)
                {
                    txtNewPassword.Focus();
                }
                else
                {
                    txtOldPassword.Focus();
                }
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtNewPassword.Text.Length > 0)
                {
                    txtConfirmPassword.Focus();
                }
                else
                {
                    txtNewPassword.Focus();
                }
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtConfirmPassword.Text.Length > 0)
                {
                    btnChange.Focus();
                }
                else
                {
                    txtConfirmPassword.Focus();
                }
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change password", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Connection con = new Connection();
                con.dataGet("Select 1 from [User] Where UserName = '"+txtUserName.Text+"' and Password = '"+txtOldPassword.Text+"'");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    if(txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        if(txtNewPassword.Text.Length > 3)
                        {
                            con.dataSend("Update [User] Set Password = '" + txtNewPassword.Text + "' Where UserName = '" + txtUserName.Text + "' and Password = '" + txtOldPassword.Text + "'");
                            MessageBox.Show("Password changed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            errorProvider1.SetError(txtNewPassword, "Please enter minimum 4 characters password");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtNewPassword, "Password mismatch");
                        errorProvider1.SetError(txtConfirmPassword, "Password mismatch");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUserName, "Please check user name and password");
                    errorProvider1.SetError(txtOldPassword, "Please check user name and password");
                }
            }
        }
    }
}
