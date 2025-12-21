using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            LoadData();
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
        // DB connection
        Connection con = new Connection();

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

        private void ClearDate()
        {
            txtName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbRole.SelectedIndex = -1;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            dtpDob.Value = DateTime.Now;
        }

        private bool Validation()
        {
            bool result = false;
            if(string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, "Name Required");
            }
            else if(string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUserName, "User Name Required");
            }
            else if(string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Password Required");
            }
            else if(txtPassword.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Password should be longer than 4 characters");
            }
            else if(string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Email Required");
            }
            else if(cmbRole.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbRole, "Select Role");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        // checks DB for existing user 
        private bool IfUserNameExists(string userName)
        {
            con.dataGet("Select 1 From [User] WHERE [UserName]= '" + userName + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a new user
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                if (IfUserNameExists(txtUserName.Text))
                {
                    MessageBox.Show("User Name already exists");
                }
                else
                {
                    con.dataSend("INSERT INTO [User](Name, Email, UserName, Password, Role, Dob, Address)VALUES('"+txtName.Text+"','"+txtEmail.Text+"','"+txtUserName.Text+"','"+txtPassword.Text+"','"+cmbRole.Text+"','"+dtpDob.Value.ToString("MM/dd/yyyy")+"','"+txtAddress.Text+"')");
                    MessageBox.Show("Record saved successfully");
                    ClearDate();
                    LoadData();
                }
            }
        }
        
        // load user data
        private void LoadData()
        {
            con.dataGet("Select * from [User]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSno"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgName"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["dgDob"].Value = Convert.ToDateTime(row["Dob"]).ToString("MM/dd/yyyy");
                dataGridView1.Rows[n].Cells["dgEmail"].Value = row["Email"].ToString();
                dataGridView1.Rows[n].Cells["dgUserName"].Value = row["UserName"].ToString();
                dataGridView1.Rows[n].Cells["dgRole"].Value = row["Role"].ToString();
                dataGridView1.Rows[n].Cells["dgAddress"].Value = row["Address"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtName.Text = dataGridView1.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells["dgUserName"].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            dtpDob.Text = dataGridView1.SelectedRows[0].Cells["dgDob"].Value.ToString();
            cmbRole.Text = dataGridView1.SelectedRows[0].Cells["dgRole"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE [User] SET Name ='"+txtName.Text+"', Email ='"+txtEmail.Text+"', Role ='"+cmbRole.Text+"', Dob ='"+dtpDob.Value.ToString("MM/dd/yyyy") +"', Address ='"+txtAddress.Text+"' Where UserName = '"+txtUserName.Text+"'");
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
