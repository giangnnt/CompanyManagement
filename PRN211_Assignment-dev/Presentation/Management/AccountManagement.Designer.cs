namespace Presentation.Management
{
    partial class AccountManagement
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
            txtUserName = new TextBox();
            lbUserName = new Label();
            dgvInfo = new DataGridView();
            txtPassword = new TextBox();
            lbPassword = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtRole = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(139, 85);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(176, 34);
            txtUserName.TabIndex = 3;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.Location = new Point(28, 88);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(107, 28);
            lbUserName.TabIndex = 2;
            lbUserName.Text = "Username*";
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Location = new Point(372, 12);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersWidth = 51;
            dgvInfo.RowTemplate.Height = 29;
            dgvInfo.Size = new Size(416, 426);
            dgvInfo.TabIndex = 4;
            dgvInfo.CellDoubleClick += dgvInfo_CellDoubleClick;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(139, 145);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 34);
            txtPassword.TabIndex = 6;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(34, 148);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(101, 28);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password*";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(97, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(224, 365);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 34);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(224, 296);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.Location = new Point(139, 206);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(176, 34);
            txtRole.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 209);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 13;
            label1.Text = "Role";
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRole);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(dgvInfo);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Name = "AccountManagement";
            Text = "AccountManagement";
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label lbUserName;
        private DataGridView dgvInfo;
        private TextBox txtPassword;
        private Label lbPassword;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtRole;
        private Label label1;
    }
}