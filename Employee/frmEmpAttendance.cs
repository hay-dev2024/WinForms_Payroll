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
    public partial class frmEmpAttendance : Form
    {
        public frmEmpAttendance()
        {
            InitializeComponent();
        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTotalDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtWorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPresentDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtAbsentDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtLopDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // Dynamic DataView
        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;

        void Search()
        {
            dgview = new DataGridView();
            dgviewcol1 = new DataGridViewTextBoxColumn();
            dgviewcol2 = new DataGridViewTextBoxColumn();

            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; 
            this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgviewcol1, this.dgviewcol2 }); 
            this.dgview.Name = "dgview";

            dgview.Visible = false;
            this.dgviewcol1.Visible = false;
            this.dgviewcol2.Visible = false;
            this.dgview.AllowUserToAddRows = false;
            this.dgview.RowHeadersVisible = false;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //this.dgview.KeyDown += new System.Windows.Forms.KeyPressEventHandler(this.dgview_KeyDown);

            // 이벤트 연결
            this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_MouseDoubleClick);

            this.Controls.Add(dgview);
            this.dgview.ReadOnly = true;
            dgview.BringToFront();
        }

        // Two Colums
        void Search(int LX, int LY, int DW, int DH, string ColName, string ColSize)
        {
            this.dgview.Location = new System.Drawing.Point(LX, LY);
            this.dgview.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = ColSize.Split(',');
            // Size
            for(int i = 0; i < ClSize.Length; i++)
            {
                if (int.Parse(ClSize[i]) != 0)
                {
                    dgview.Columns[i].Width = int.Parse(ClSize[i]);
                }
                else
                {
                    dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            // Name
            string[] ClName = ColName.Split(',');
            for(int i = 0; i < ClName.Length; i++)
            {
                this.dgview.Columns[i].HeaderText = ClName[i];
                this.dgview.Columns[i].Visible = true;
            }
        }

        private void frmEmpAttendance_Load(object sender, EventArgs e)
        {
            Search();
            this.ActiveControl = txtEmpId;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            if(txtEmpId.Text.Length > 0)
            {
                this.dgview.Visible = true;
                dgview.BringToFront();
                Search(90, 70, 400, 200, "Emp Id,Emp Name", "100,0");

                //this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_MouseDoubleClick);

                Connection con = new Connection();
                con.dataGet("Select Top(10) EmpId,Name From Employee Where EmpId Like '" + txtEmpId.Text + "%'");

                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                dgview.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dgview.Rows.Add();
                    dgview.Rows[n].Cells[0].Value = row["EmpId"].ToString();
                    dgview.Rows[n].Cells[1].Value = row["Name"].ToString();
                }
            }
            else
            {
                dgview.Visible = false;
            }
        }

        bool change = true;
        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(change)
            {
                change = false;
                txtEmpId.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                txtEmpName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                this.dgview.Visible = false;
                cmbYear.Focus();
                change = true;
            }
        }

        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dgview.Rows.Count > 0)
                {
                    txtEmpId.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    this.dgview.Visible = false;
                    cmbYear.Focus();
                }
                else
                {
                    this.dgview.Visible = false;
                }
            }
        }

        private void cmbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cmbYear.SelectedIndex != -1)
                {
                    cmbMonth.Focus();
                }
                else
                {
                    cmbYear.Focus();
                }
            }
        }

        private void cmbMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cmbMonth.SelectedIndex != -1)
                {
                    txtTotalDays.Focus();
                }
                else
                {
                    cmbMonth.Focus();
                }
            }
        }

        private void txtTotalDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTotalDays.Text.Length > 0)
                {
                    txtWorkingDays.Focus();
                }
                else
                {
                    txtTotalDays.Focus();
                }
            }
        }

        private void txtWorkingDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtWorkingDays.Text.Length > 0)
                {
                    txtPresentDays.Focus();
                }
                else
                {
                    txtWorkingDays.Focus();
                }
            }
        }

        private void txtPresentDays_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtAbsentDays.Focus();
            }
        }

        private void txtAbsentDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLopDays.Focus();
            }
        }

        private void txtLopDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        Connection con = new Connection();
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMonth.SelectedIndex != -1)
            {
                con.dataGet("Select * From EmpAttendance Where EmpId = '"+txtEmpId.Text+"' and Year = '"+cmbYear.Text+"' and Month = '"+cmbMonth.Text+"'");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    txtTotalDays.Text = dt.Rows[0]["TotalDays"].ToString();
                    txtWorkingDays.Text = dt.Rows[0]["WorkingDays"].ToString(); 
                    txtPresentDays.Text = dt.Rows[0]["PresentDays"].ToString();
                    txtAbsentDays.Text = dt.Rows[0]["AbsentDays"].ToString();
                    txtLopDays.Text = dt.Rows[0]["LopDays"].ToString();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    txtTotalDays.Text = "";
                    txtWorkingDays.Text = "";
                    txtPresentDays.Text = "";
                    txtAbsentDays.Text = "";
                    txtLopDays.Text = "";
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private bool Validation()
        {
            bool result = false;
            if(string.IsNullOrEmpty(txtEmpId.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpId, "Emp ID required");
            }
            else if(string.IsNullOrEmpty(cmbYear.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "Select year");
            }
            else if (string.IsNullOrEmpty(cmbMonth.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMonth, "Select month");
            }
            else if (string.IsNullOrEmpty(txtTotalDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTotalDays, "Total days required");
            }
            else if (string.IsNullOrEmpty(txtWorkingDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtWorkingDays, "Working days required");
            }
            else if (string.IsNullOrEmpty(txtPresentDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPresentDays, "Present days required");
            }
            //else if (string.IsNullOrEmpty(txtAbsentDays.Text))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtAbsentDays, "Absent days required");
            //}
            //else if (string.IsNullOrEmpty(txtLopDays.Text))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtLopDays, "LOP days required");
            //}
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                con.dataSend(@"INSERT INTO EmpAttendance (EmpId, Year, Month, TotalDays, WorkingDays, PresentDays, AbsentDays, LopDays)
                                VALUES  ('"+txtEmpId.Text+"','"+cmbYear.Text+"','"+cmbMonth.Text+"','"+txtTotalDays.Text+"','"+txtWorkingDays.Text+"','"+txtPresentDays.Text+"','"+txtAbsentDays.Text+"','"+txtLopDays.Text+"')");
                MessageBox.Show("Saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
        }

        private void ClearData()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            cmbYear.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
            txtTotalDays.Clear();
            txtWorkingDays.Clear();
            txtPresentDays.Clear();
            txtAbsentDays.Clear();
            txtLopDays.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE EmpAttendance SET PresentDays = '"+txtPresentDays.Text+"', AbsentDays ='"+txtAbsentDays.Text+"', TotalDays ='"+txtTotalDays.Text+"', WorkingDays ='"+txtWorkingDays.Text+"', LopDays ='"+txtLopDays.Text+"' Where EmpId ='"+txtEmpId.Text+"' And Year ='"+cmbYear.Text+ "' And Month ='" + cmbMonth.Text+"'");
                MessageBox.Show("Updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
        }
    }
}
