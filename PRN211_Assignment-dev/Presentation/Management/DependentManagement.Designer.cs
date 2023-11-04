namespace Presentation.Management
{
    partial class DependentManagement
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
            txtdepName = new TextBox();
            lbdepName = new Label();
            dgvInfor = new DataGridView();
            btnAdd = new Button();
            txtempSSN = new TextBox();
            lbempSSN = new Label();
            lbdepSex = new Label();
            lbdepBirthDate = new Label();
            label5 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            cbdepSex = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            cbdepRelationship = new ComboBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInfor).BeginInit();
            SuspendLayout();
            // 
            // txtdepName
            // 
            txtdepName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdepName.Location = new Point(205, 90);
            txtdepName.Margin = new Padding(2);
            txtdepName.Name = "txtdepName";
            txtdepName.Size = new Size(216, 34);
            txtdepName.TabIndex = 0;
            // 
            // lbdepName
            // 
            lbdepName.AutoSize = true;
            lbdepName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdepName.Location = new Point(22, 90);
            lbdepName.Margin = new Padding(2, 0, 2, 0);
            lbdepName.Name = "lbdepName";
            lbdepName.Size = new Size(166, 28);
            lbdepName.TabIndex = 1;
            lbdepName.Text = "Dependent Name";
            // 
            // dgvInfor
            // 
            dgvInfor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfor.Location = new Point(453, 17);
            dgvInfor.Margin = new Padding(2);
            dgvInfor.Name = "dgvInfor";
            dgvInfor.RowHeadersWidth = 62;
            dgvInfor.RowTemplate.Height = 33;
            dgvInfor.Size = new Size(651, 405);
            dgvInfor.TabIndex = 2;
            dgvInfor.CellDoubleClick += dgvInfor_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(95, 308);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtempSSN
            // 
            txtempSSN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtempSSN.Location = new Point(205, 42);
            txtempSSN.Margin = new Padding(2);
            txtempSSN.Name = "txtempSSN";
            txtempSSN.Size = new Size(216, 34);
            txtempSSN.TabIndex = 4;
            // 
            // lbempSSN
            // 
            lbempSSN.AutoSize = true;
            lbempSSN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbempSSN.Location = new Point(67, 42);
            lbempSSN.Margin = new Padding(2, 0, 2, 0);
            lbempSSN.Name = "lbempSSN";
            lbempSSN.Size = new Size(122, 28);
            lbempSSN.TabIndex = 8;
            lbempSSN.Text = "Employee ID";
            // 
            // lbdepSex
            // 
            lbdepSex.AutoSize = true;
            lbdepSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdepSex.Location = new Point(113, 145);
            lbdepSex.Margin = new Padding(2, 0, 2, 0);
            lbdepSex.Name = "lbdepSex";
            lbdepSex.Size = new Size(76, 28);
            lbdepSex.TabIndex = 9;
            lbdepSex.Text = "Gender";
            // 
            // lbdepBirthDate
            // 
            lbdepBirthDate.AutoSize = true;
            lbdepBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdepBirthDate.Location = new Point(95, 195);
            lbdepBirthDate.Margin = new Padding(2, 0, 2, 0);
            lbdepBirthDate.Name = "lbdepBirthDate";
            lbdepBirthDate.Size = new Size(94, 28);
            lbdepBirthDate.TabIndex = 10;
            lbdepBirthDate.Text = "BirthDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(71, 246);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 11;
            label5.Text = "Relationship";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(294, 308);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(95, 382);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 40);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbdepSex
            // 
            cbdepSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbdepSex.FormattingEnabled = true;
            cbdepSex.Location = new Point(205, 142);
            cbdepSex.Margin = new Padding(2);
            cbdepSex.Name = "cbdepSex";
            cbdepSex.Size = new Size(216, 36);
            cbdepSex.TabIndex = 15;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "yyyy/MM/dd";
            dtpBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(205, 195);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(216, 34);
            dtpBirthDate.TabIndex = 32;
            // 
            // cbdepRelationship
            // 
            cbdepRelationship.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbdepRelationship.FormattingEnabled = true;
            cbdepRelationship.Location = new Point(205, 244);
            cbdepRelationship.Margin = new Padding(2);
            cbdepRelationship.Name = "cbdepRelationship";
            cbdepRelationship.Size = new Size(216, 36);
            cbdepRelationship.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.HotTrack;
            btnCancel.Location = new Point(294, 382);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 40);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DependentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 458);
            Controls.Add(btnCancel);
            Controls.Add(cbdepRelationship);
            Controls.Add(dtpBirthDate);
            Controls.Add(cbdepSex);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(lbdepBirthDate);
            Controls.Add(lbdepSex);
            Controls.Add(lbempSSN);
            Controls.Add(txtempSSN);
            Controls.Add(btnAdd);
            Controls.Add(dgvInfor);
            Controls.Add(lbdepName);
            Controls.Add(txtdepName);
            Margin = new Padding(2);
            Name = "DependentManagement";
            Text = "DependentManagement";
            ((System.ComponentModel.ISupportInitialize)dgvInfor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdepName;
        private Label lbdepName;
        private DataGridView dgvInfor;
        private Button btnAdd;
        private TextBox txtempSSN;
        private TextBox textBox3;
        private Label lbempSSN;
        private Label lbdepSex;
        private Label lbdepBirthDate;
        private Label label5;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbdepSex;
        private DateTimePicker dtpBirthDate;
        private ComboBox cbdepRelationship;
        private Button btnCancel;
    }
}