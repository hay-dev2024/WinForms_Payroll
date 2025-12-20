namespace Payroll.User
{
    partial class frmUserRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dob : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Role : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(131, 79);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 21);
            this.txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(227, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(131, 156);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(547, 56);
            this.txtAddress.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(451, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 21);
            this.txtEmail.TabIndex = 8;
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "dd/MM/yyyy";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(452, 82);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(226, 21);
            this.dtpDob.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(322, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 41);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(439, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(452, 116);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(226, 20);
            this.cbRole.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgName,
            this.dgDob,
            this.dgEmail,
            this.dgUserName,
            this.dgRole,
            this.dgAddress});
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(766, 268);
            this.dataGridView1.TabIndex = 12;
            // 
            // dgSno
            // 
            this.dgSno.HeaderText = "S.No";
            this.dgSno.Name = "dgSno";
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            // 
            // dgDob
            // 
            this.dgDob.HeaderText = "Dob";
            this.dgDob.Name = "dgDob";
            // 
            // dgEmail
            // 
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            // 
            // dgUserName
            // 
            this.dgUserName.HeaderText = "User Name";
            this.dgUserName.Name = "dgUserName";
            // 
            // dgRole
            // 
            this.dgRole.HeaderText = "Role";
            this.dgRole.Name = "dgRole";
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            // 
            // frmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUserRegister";
            this.Text = "User Register";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
    }
}