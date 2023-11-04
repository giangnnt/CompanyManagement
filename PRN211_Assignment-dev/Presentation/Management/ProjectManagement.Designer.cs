namespace Presentation.Management
{
    partial class ProjectManagement
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProName = new TextBox();
            txtProDepa = new TextBox();
            txtProLoc = new TextBox();
            button1 = new Button();
            label4 = new Label();
            txtProNum = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(528, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(749, 760);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 160);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 1;
            label1.Text = "Project Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 263);
            label2.Name = "label2";
            label2.Size = new Size(232, 35);
            label2.TabIndex = 2;
            label2.Text = "Project Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 359);
            label3.Name = "label3";
            label3.Size = new Size(194, 35);
            label3.TabIndex = 3;
            label3.Text = "Project Location";
            // 
            // txtProName
            // 
            txtProName.Location = new Point(289, 160);
            txtProName.Margin = new Padding(3, 4, 3, 4);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(174, 27);
            txtProName.TabIndex = 4;
            // 
            // txtProDepa
            // 
            txtProDepa.Location = new Point(289, 263);
            txtProDepa.Margin = new Padding(3, 4, 3, 4);
            txtProDepa.Name = "txtProDepa";
            txtProDepa.Size = new Size(174, 27);
            txtProDepa.TabIndex = 5;
            // 
            // txtProLoc
            // 
            txtProLoc.Location = new Point(289, 359);
            txtProLoc.Margin = new Padding(3, 4, 3, 4);
            txtProLoc.Name = "txtProLoc";
            txtProLoc.Size = new Size(174, 27);
            txtProLoc.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(41, 521);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(99, 52);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddProject;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 68);
            label4.Name = "label4";
            label4.Size = new Size(191, 35);
            label4.TabIndex = 8;
            label4.Text = "Project Number";
            // 
            // txtProNum
            // 
            txtProNum.Location = new Point(289, 68);
            txtProNum.Margin = new Padding(3, 4, 3, 4);
            txtProNum.Name = "txtProNum";
            txtProNum.Size = new Size(174, 27);
            txtProNum.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(203, 521);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(109, 52);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateProject;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(365, 521);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(99, 52);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteProject;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(364, 628);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(99, 52);
            button4.TabIndex = 14;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ProjectManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 792);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtProNum);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtProLoc);
            Controls.Add(txtProDepa);
            Controls.Add(txtProName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProjectManagement";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProName;
        private TextBox txtProDepa;
        private TextBox txtProLoc;
        private Button button1;
        private Label label4;
        private TextBox txtProNum;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}