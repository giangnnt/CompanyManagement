namespace Presentation.Management
{
    partial class EmployeeManagement
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
            txtAddress = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtName = new TextBox();
            lbPassword = new Label();
            dgvInfo = new DataGridView();
            txtID = new TextBox();
            lbUserName = new Label();
            txtSalary = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpBirthDate = new DateTimePicker();
            label5 = new Label();
            txtSupervisorID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dtpStartDate = new DateTimePicker();
            cbGender = new ComboBox();
            cbDepNum = new ComboBox();
            btnCancel = new Button();
            btnDetail = new Button();
            cbStatus = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(145, 133);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(175, 34);
            txtAddress.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 135);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 23;
            label1.Text = "Address";
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(229, 659);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 35);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(229, 603);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 35);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(145, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 34);
            txtName.TabIndex = 19;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(75, 77);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(64, 28);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Name";
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Location = new Point(355, 12);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersWidth = 51;
            dgvInfo.RowTemplate.Height = 29;
            dgvInfo.Size = new Size(1206, 867);
            dgvInfo.TabIndex = 17;
            dgvInfo.CellDoubleClick += dgvInfo_CellDoubleClick;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(145, 20);
            txtID.Name = "txtID";
            txtID.Size = new Size(175, 34);
            txtID.TabIndex = 16;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.Location = new Point(107, 21);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(31, 28);
            lbUserName.TabIndex = 15;
            lbUserName.Text = "ID";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(145, 192);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(175, 34);
            txtSalary.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 192);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 25;
            label2.Text = "Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 249);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 27;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 307);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 29;
            label4.Text = "BirthDate";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "yyyy/MM/dd";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(145, 309);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(175, 27);
            dtpBirthDate.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 363);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 32;
            label5.Text = "DepNum";
            // 
            // txtSupervisorID
            // 
            txtSupervisorID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupervisorID.Location = new Point(145, 419);
            txtSupervisorID.Name = "txtSupervisorID";
            txtSupervisorID.Size = new Size(175, 34);
            txtSupervisorID.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 420);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 34;
            label6.Text = "Supervisor ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(40, 477);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 36;
            label7.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "yyyy/MM/dd";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(145, 480);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(175, 27);
            dtpStartDate.TabIndex = 38;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(145, 251);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(175, 28);
            cbGender.TabIndex = 39;
            // 
            // cbDepNum
            // 
            cbDepNum.FormattingEnabled = true;
            cbDepNum.Location = new Point(145, 365);
            cbDepNum.Name = "cbDepNum";
            cbDepNum.Size = new Size(175, 28);
            cbDepNum.TabIndex = 40;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.HotTrack;
            btnCancel.Location = new Point(229, 715);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 35);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDetail
            // 
            btnDetail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetail.ForeColor = SystemColors.HotTrack;
            btnDetail.Location = new Point(74, 715);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(133, 35);
            btnDetail.TabIndex = 42;
            btnDetail.Text = "View Details";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(145, 533);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(175, 28);
            cbStatus.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(73, 531);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 44;
            label8.Text = "Active";
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 891);
            Controls.Add(label8);
            Controls.Add(cbStatus);
            Controls.Add(btnDetail);
            Controls.Add(btnCancel);
            Controls.Add(cbDepNum);
            Controls.Add(cbGender);
            Controls.Add(dtpStartDate);
            Controls.Add(label7);
            Controls.Add(txtSupervisorID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpBirthDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSalary);
            Controls.Add(label2);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(lbPassword);
            Controls.Add(dgvInfo);
            Controls.Add(txtID);
            Controls.Add(lbUserName);
            Name = "EmployeeManagement";
            Text = "EmployeeManagement";
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddress;
        private Label label1;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtName;
        private Label lbPassword;
        private DataGridView dgvInfo;
        private TextBox txtID;
        private Label lbUserName;
        private TextBox txtSalary;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpBirthDate;
        private Label label5;
        private TextBox txtSupervisorID;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpStartDate;
        private ComboBox cbGender;
        private ComboBox cbDepNum;
        private Button btnCancel;
        private Button btnDetail;
        private ComboBox cbStatus;
        private Label label8;
    }
}