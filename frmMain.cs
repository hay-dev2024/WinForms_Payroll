using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 메인 폼이 닫힐 때, 프로그램(Application) 전체를 완전히 종료
            Application.Exit();
        }

        private void userRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // User Register
            User.frmUserRegister frm = new User.frmUserRegister();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
