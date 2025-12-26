using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadDate();
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

        // Mobile - numeric value and a couple characters only
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private bool Validation()
        {
            bool result = false;
            if(string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, "Name Required");
            }
            else if(string.IsNullOrEmpty(txtMobile.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMobile, "Mobile number required");
            }
            else if(string.IsNullOrEmpty(txtTin.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTin, "TIN No. required");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Email Required");
            }
            else if(string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAddress, "Address Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        // DB
        Connection con = new Connection();
        private bool IfEmployeeExists(string name, string mobile, string tinNo)
        {
            con.dataGet("Select 1 From Employee Where Name = '" + name + "' And Mobile = '" + mobile + "' And TINNo = '" + tinNo + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                if(IfEmployeeExists(txtName.Text, txtMobile.Text, txtTin.Text))
                {
                    MessageBox.Show("Employee already exists");
                }
                else
                {
                    try
                    {
                        string connString = con.dbAddr;

                        using(System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(connString))
                        {
                            string sql = @"INSERT INTO Employee (Name, Mobile, Email, TINNo, Dob, BankDetails, Address, FileName, ImageData) 
                                        VALUES
                                        (@Name, @Mobile, @Email, @TINNo, @Dob, @BankDetails, @Address, @FileName, @ImageData)";
                            using(System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, sqlCon))
                            {
                                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@TINNo", txtTin.Text);
                                cmd.Parameters.AddWithValue("@Dob", dtpDob.Value);
                                cmd.Parameters.AddWithValue("@BankDetails", txtBankDetails.Text);
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@FileName", fileName ?? "");

                                if(pictureBox.Image != null)
                                {
                                    using(System.IO.MemoryStream ms = new System.IO.MemoryStream())
                                    {
                                        pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        cmd.Parameters.AddWithValue("@ImageData", ms.ToArray());
                                    }
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@ImageData", DBNull.Value);
                                }

                                sqlCon.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadDate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error\n" + ex.Message);
                    }
                }
            }
        }

        private void ClearData()
        {
            txtName.Clear();
            txtEmpId.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtTin.Clear();
            dtpDob.Value = DateTime.Now;
            txtBankDetails.Clear();
            txtAddress.Clear();
            pictureBox.Image = null;
        }

        private void LoadDate()
        {
            con.dataGet("Select * from Employee");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgEmpId"].Value = row["EmpId"].ToString();
                dataGridView1.Rows[n].Cells["dgName"].Value = row["Name"].ToString();

                if (row["Dob"] != DBNull.Value && row["Dob"].ToString() != "")
                {
                    try
                    {
                        dataGridView1.Rows[n].Cells["dgDob"].Value = Convert.ToDateTime(row["Dob"].ToString()).ToString("dd/MM/yyyy");
                    }
                    catch (Exception)
                    {
                        dataGridView1.Rows[n].Cells["dgDob"].Value = "";
                    }
                }
                else
                {
                    dataGridView1.Rows[n].Cells["dgDob"].Value = "";
                }

                dataGridView1.Rows[n].Cells["dgEmail"].Value = row["Email"].ToString();
                dataGridView1.Rows[n].Cells["dgMobile"].Value = row["Mobile"].ToString();
                dataGridView1.Rows[n].Cells["dgTinNo"].Value = row["TINNo"].ToString();
                dataGridView1.Rows[n].Cells["dgBankDetails"].Value = row["BankDetails"].ToString();
                dataGridView1.Rows[n].Cells["dgAddress"].Value = row["Address"].ToString();
                dataGridView1.Rows[n].Cells["dgFileName"].Value = row["FileName"].ToString();
                dataGridView1.Rows[n].Cells["dgImageData"].Value = row["ImageData"].ToString();

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpId.Text = dataGridView1.SelectedRows[0].Cells["dgEmpId"].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtMobile.Text = dataGridView1.SelectedRows[0].Cells["dgMobile"].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtTin.Text = dataGridView1.SelectedRows[0].Cells["dgTinNo"].Value.ToString();

            string dobValue = dataGridView1.SelectedRows[0].Cells["dgDob"].Value.ToString();
            DateTime dt;
            if(DateTime.TryParse(dobValue, out dt))
            {
                dtpDob.Value = dt;
            }
            else
            {
                dtpDob.Value = DateTime.Now;
            }
            
            txtBankDetails.Text = dataGridView1.SelectedRows[0].Cells["dgBankDetails"].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            
            string path = dataGridView1.SelectedRows[0].Cells["dgFileName"].Value.ToString();
            
            lblFileName.Text = path;

            if(System.IO.File.Exists(path))
            {
                pictureBox.Image = Image.FromFile(path);
            }
            else
            {
                pictureBox.Image = null;
            }
        }
    }
}
