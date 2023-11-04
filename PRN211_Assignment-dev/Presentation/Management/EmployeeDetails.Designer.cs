namespace Presentation.Management
{
    partial class EmployeeDetails
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
            dgvDependent = new DataGridView();
            dgvWorksOn = new DataGridView();
            txtID = new TextBox();
            lbUserName = new Label();
            label1 = new Label();
            lbSalary = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDependent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWorksOn).BeginInit();
            SuspendLayout();
            // 
            // dgvDependent
            // 
            dgvDependent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDependent.Location = new Point(259, 18);
            dgvDependent.Name = "dgvDependent";
            dgvDependent.RowHeadersWidth = 51;
            dgvDependent.RowTemplate.Height = 29;
            dgvDependent.Size = new Size(519, 194);
            dgvDependent.TabIndex = 0;
            // 
            // dgvWorksOn
            // 
            dgvWorksOn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorksOn.Location = new Point(259, 238);
            dgvWorksOn.Name = "dgvWorksOn";
            dgvWorksOn.RowHeadersWidth = 51;
            dgvWorksOn.RowTemplate.Height = 29;
            dgvWorksOn.Size = new Size(521, 190);
            dgvWorksOn.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(54, 173);
            txtID.Name = "txtID";
            txtID.Size = new Size(176, 34);
            txtID.TabIndex = 18;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.Location = new Point(17, 174);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(31, 28);
            lbUserName.TabIndex = 17;
            lbUserName.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 242);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 19;
            label1.Text = "Salary:";
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSalary.Location = new Point(88, 242);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(0, 28);
            lbSalary.TabIndex = 20;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbSalary);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(lbUserName);
            Controls.Add(dgvWorksOn);
            Controls.Add(dgvDependent);
            Name = "EmployeeDetails";
            Text = "EmployeeDetails";
            ((System.ComponentModel.ISupportInitialize)dgvDependent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWorksOn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDependent;
        private DataGridView dgvWorksOn;
        private TextBox txtID;
        private Label lbUserName;
        private Label label1;
        private Label lbSalary;
    }
}