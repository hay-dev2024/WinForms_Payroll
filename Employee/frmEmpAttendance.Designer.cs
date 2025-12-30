namespace Payroll.Employee
{
    partial class frmEmpAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkingDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPresentDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAbsentDays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLopDays = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp ID :";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(93, 27);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(193, 21);
            this.txtEmpId.TabIndex = 1;
            this.txtEmpId.TextChanged += new System.EventHandler(this.txtEmpId_TextChanged);
            this.txtEmpId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpId_KeyDown);
            this.txtEmpId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emp Name :";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(387, 27);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(193, 21);
            this.txtEmpName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Month :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Days :";
            // 
            // txtTotalDays
            // 
            this.txtTotalDays.Location = new System.Drawing.Point(93, 98);
            this.txtTotalDays.Name = "txtTotalDays";
            this.txtTotalDays.Size = new System.Drawing.Size(193, 21);
            this.txtTotalDays.TabIndex = 1;
            this.txtTotalDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalDays_KeyDown);
            this.txtTotalDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDays_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Working Days :";
            // 
            // txtWorkingDays
            // 
            this.txtWorkingDays.Location = new System.Drawing.Point(389, 98);
            this.txtWorkingDays.Name = "txtWorkingDays";
            this.txtWorkingDays.Size = new System.Drawing.Size(193, 21);
            this.txtWorkingDays.TabIndex = 1;
            this.txtWorkingDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkingDays_KeyDown);
            this.txtWorkingDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkingDays_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Present Days :";
            // 
            // txtPresentDays
            // 
            this.txtPresentDays.Location = new System.Drawing.Point(108, 145);
            this.txtPresentDays.Name = "txtPresentDays";
            this.txtPresentDays.Size = new System.Drawing.Size(102, 21);
            this.txtPresentDays.TabIndex = 1;
            this.txtPresentDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPresentDays_KeyDown);
            this.txtPresentDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresentDays_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Absent Days :";
            // 
            // txtAbsentDays
            // 
            this.txtAbsentDays.Location = new System.Drawing.Point(307, 145);
            this.txtAbsentDays.Name = "txtAbsentDays";
            this.txtAbsentDays.Size = new System.Drawing.Size(102, 21);
            this.txtAbsentDays.TabIndex = 1;
            this.txtAbsentDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAbsentDays_KeyDown);
            this.txtAbsentDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbsentDays_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "LOP Days :";
            // 
            // txtLopDays
            // 
            this.txtLopDays.Location = new System.Drawing.Point(491, 145);
            this.txtLopDays.Name = "txtLopDays";
            this.txtLopDays.Size = new System.Drawing.Size(102, 21);
            this.txtLopDays.TabIndex = 1;
            this.txtLopDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLopDays_KeyDown);
            this.txtLopDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLopDays_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(228, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(436, 201);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 28);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbYear.Location = new System.Drawing.Point(93, 63);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(193, 20);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbYear_KeyDown);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(387, 63);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(193, 20);
            this.cmbMonth.TabIndex = 3;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            this.cmbMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMonth_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmEmpAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 261);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWorkingDays);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLopDays);
            this.Controls.Add(this.txtAbsentDays);
            this.Controls.Add(this.txtPresentDays);
            this.Controls.Add(this.txtTotalDays);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpAttendance";
            this.Text = "Employee Attendance";
            this.Load += new System.EventHandler(this.frmEmpAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkingDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPresentDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAbsentDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLopDays;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}