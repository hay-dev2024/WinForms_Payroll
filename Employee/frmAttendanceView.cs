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
    public partial class frmAttendanceView : Form
    {
        public frmAttendanceView()
        {
            InitializeComponent();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSearch.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
            }
            if (cmbSearch.SelectedIndex != 0)
            {
                txtSearch.Visible = true;
                txtSearch.Clear();
            }
        }

        // Dynamic datagrid view
        private DataGridView dgView;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;

        void Search()
        {
            dgView = new DataGridView();
            dgviewcol1 = new DataGridViewTextBoxColumn();
            dgviewcol2 = new DataGridViewTextBoxColumn();

            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgviewcol1, this.dgviewcol2 });
            this.dgView.Name = "dgview";

            dgView.Visible = false;
            this.dgviewcol1.Visible = false;
            this.dgviewcol2.Visible = false;
            this.dgView.AllowUserToAddRows = false;
            this.dgView.RowHeadersVisible = false;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //this.dgView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgView_KeyDown);

            this.Controls.Add(dgView);
            this.dgView.ReadOnly = true;
            dgView.BringToFront();
            
        }

        // Two Column
        void Search(int LX, int LY, int DW, int DH, string ColName, string ColSize)
        {
            this.dgView.Location = new System.Drawing.Point(LX, LY);
            this.dgView.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = ColSize.Split(',');
            // Size
            for(int i = 0; i < ClSize.Length; i++)
            {
                if (int.Parse(ClSize[i]) != 0)
                {
                    dgView.Columns[i].Width = int.Parse(ClSize[i]);
                }
                else
                {
                    dgView.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            // Name
            string[] ClName = ColName.Split(',');

            for(int i = 0; i < ClName.Length; i++)
            {
                this.dgView.Columns[i].HeaderText = ClName[i];
                this.dgView.Columns[i].Visible = true;
            }
        }

        bool change = true;
        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(change)
            {
                change = false;
                txtSearch.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                this.dgView.Visible = false;
                cmbYear.Focus();
                change = true;
            }
        }


        private void frmAttendanceView_Load(object sender, EventArgs e)
        {
            Search();
            txtSearch.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length != 0)
            {
                if(cmbSearch.SelectedIndex == 1)
                {
                    this.dgView.Visible = true;
                    dgView.BringToFront();
                    Search(120, 90, 400, 200, "Emp ID,Emp Name", "100,0");
                    this.dgView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_MouseDoubleClick);
                    
                    Connection con = new Connection();
                    con.dataGet("Select Top(10) EmpId,Name From Employee WHere EmpId Like '" + txtSearch.Text + "%'");
                    DataTable dt = new DataTable();
                    con.sda.Fill(dt);
                    
                    dgView.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        int n = dgView.Rows.Add();
                        dgView.Rows[n].Cells[0].Value = row["EmpId"].ToString();
                        dgView.Rows[n].Cells[1].Value = row["Name"].ToString();
                    }

                }
            }
        }
        Connection con = new Connection();
        void LoadData(string condition)
        {
            con.dataGet("Select EmpAttendance.*,Employee.Name From Employee Inner Join EmpAttendance On Employee.EmpId = EmpAttendance.EmpId " + condition + "");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgEmpId"].Value = row["EmpId"].ToString();
                dataGridView1.Rows[n].Cells["dgName"].Value = row["Name"].ToString();


            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dgView.Rows.Count > 0)
                {
                    txtSearch.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                    dgView.Visible = false;
                    cmbYear.Focus();
                }
                else
                {
                    this.dgView.Visible = false;
                }
            }
        }
    }
}
