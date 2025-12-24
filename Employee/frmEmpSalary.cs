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
    public partial class frmEmpSalary : Form
    {
        public frmEmpSalary()
        {
            InitializeComponent();
        }

        Connection con = new Connection();

        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dgvEmpInfo.Rows.Count > 0)
                {
                    txtEmpId.Text = dgvEmpInfo.Rows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dgvEmpInfo.Rows[0].Cells[1].Value.ToString();
                    dtpJoinDate.Focus();

                }

            }
        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select Top(10) EmpId, Name From Employee Where EmpId Like '"+txtEmpId.Text+"%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dgvEmpInfo.DataSource = dt;
        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select Top(10) EmpId, Name From Employee Where Name Like '" + txtEmpName.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dgvEmpInfo.DataSource = dt;
        }

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvEmpInfo.Rows.Count > 0)
                {
                    txtEmpId.Text = dgvEmpInfo.Rows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dgvEmpInfo.Rows[0].Cells[1].Value.ToString();
                    dtpJoinDate.Focus();

                }

            }
        }

        private void frmEmpSalary_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtEmpId;
        }

        private void dtpJoinDate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSalary.Focus();
            }
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtSalary.Text.Length > 0)
                {
                    btnSave.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.dataSend("INSERT INTO EmpSalary (EmpId, JoinDate, Salary) VALUES ('"+txtEmpId.Text+"','"+dtpJoinDate.Value.ToString("MM/dd/yyyy")+"','"+txtSalary.Text+"')");

        }

        private bool Validation()
        {
            bool result = false;
            if(string.IsNullOrEmpty(txtEmpId.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpId, "Empn ID Required");
            }
            else if(string.IsNullOrEmpty(txtSalary.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSalary, "Salary Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
    }
}
