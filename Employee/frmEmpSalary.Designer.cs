namespace Payroll.Employee
{
    partial class frmEmpSalary
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpInfo = new System.Windows.Forms.DataGridView();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp ID :";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(94, 41);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(198, 21);
            this.txtEmpId.TabIndex = 1;
            this.txtEmpId.TextChanged += new System.EventHandler(this.txtEmpId_TextChanged);
            this.txtEmpId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpId_KeyDown);
            this.txtEmpId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Join Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emp Name :";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(395, 44);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(198, 21);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            this.txtEmpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salary P/A :";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(395, 78);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(198, 21);
            this.txtSalary.TabIndex = 1;
            this.txtSalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalary_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(395, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEmpId,
            this.dgEmpName,
            this.dgJoinDate,
            this.dgSalary});
            this.dataGridView1.Location = new System.Drawing.Point(80, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 303);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // dgEmpId
            // 
            this.dgEmpId.HeaderText = "Emp ID";
            this.dgEmpId.Name = "dgEmpId";
            // 
            // dgEmpName
            // 
            this.dgEmpName.HeaderText = "Emp Name";
            this.dgEmpName.Name = "dgEmpName";
            // 
            // dgJoinDate
            // 
            this.dgJoinDate.HeaderText = "Join Date";
            this.dgJoinDate.Name = "dgJoinDate";
            // 
            // dgSalary
            // 
            this.dgSalary.HeaderText = "Salary P/A";
            this.dgSalary.Name = "dgSalary";
            // 
            // dgvEmpInfo
            // 
            this.dgvEmpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpInfo.Location = new System.Drawing.Point(610, 12);
            this.dgvEmpInfo.Name = "dgvEmpInfo";
            this.dgvEmpInfo.RowTemplate.Height = 23;
            this.dgvEmpInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpInfo.Size = new System.Drawing.Size(279, 170);
            this.dgvEmpInfo.TabIndex = 4;
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoinDate.Location = new System.Drawing.Point(94, 78);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(200, 21);
            this.dtpJoinDate.TabIndex = 5;
            this.dtpJoinDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpJoinDate_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEmpSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 515);
            this.Controls.Add(this.dtpJoinDate);
            this.Controls.Add(this.dgvEmpInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpSalary";
            this.Text = "Assigning Employee Salary";
            this.Load += new System.EventHandler(this.frmEmpSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvEmpInfo;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSalary;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}