using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.Employee
{
    public partial class frmEmployeeRegister : Form
    {
        string fileName;

        public frmEmployeeRegister()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    lblFileName.Text = fileName;
                    pictureBox.Image = Image.FromFile(fileName);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void frmEmployeeRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtName.Text.Length > 0)
                {
                    txtMobile.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtMobile.Text.Length > 0)
                {
                    txtEmail.Focus();
                }
                else
                {
                    txtMobile.Focus();
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtEmail.Text.Length > 0)
                {
                    txtTin.Focus();
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void txtTin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtTin.Text.Length > 0)
                {
                    dtpDob.Focus();
                }
                else
                {
                    txtTin.Focus();
                }
            }
        }

        private void dtpDob_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtBankDetails.Focus();
            }
        }

        private void txtBankDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtBankDetails.Text.Length > 0)
                {
                    txtAddress.Focus();
                }
                else
                {
                    txtBankDetails.Focus();
                }
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtAddress.Text.Length > 0)
                {
                    btnSave.Focus();
                }
                else
                {
                    txtAddress.Focus();
                }
            }
        }
    }
}
