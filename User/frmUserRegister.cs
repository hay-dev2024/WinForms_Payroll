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
    public partial class frmUserRegister : Form
    {
        public frmUserRegister()
        {
            InitializeComponent();
        }

        private void frmUserRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtName.Text.Length > 0)
                {
                    txtUserName.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtUserName.Text.Length > 0)
                {
                    txtPassword.Focus();
                }
                else
                {
                    txtUserName.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtPassword.Text.Length > 0)
                {
                    txtEmail.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtEmail.Text.Length > 0)
                {
                    dtpDob.Focus();
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void dtpDob_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               cmbRole.Focus();
            }
        }

        private void cmbRole_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }


    }
}
