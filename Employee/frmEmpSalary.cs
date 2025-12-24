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

            }
        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select Top(10) EmpId, Name From Employee Where EmpId Like '"+txtEmpId.Text+"'%");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
