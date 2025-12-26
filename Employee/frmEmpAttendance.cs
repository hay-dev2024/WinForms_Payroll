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
    }
}
