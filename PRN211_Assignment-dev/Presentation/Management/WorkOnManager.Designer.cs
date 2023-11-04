namespace Presentation.Management
{
    partial class WorkOnManager
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
            cbproName = new ComboBox();
            cbempName = new ComboBox();
            txthours = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dvgListWorkOn = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgListWorkOn).BeginInit();
            SuspendLayout();
            // 
            // cbproName
            // 
            cbproName.FormattingEnabled = true;
            cbproName.Location = new Point(573, 45);
            cbproName.Name = "cbproName";
            cbproName.Size = new Size(215, 28);
            cbproName.TabIndex = 34;
            cbproName.SelectedIndexChanged += cbproName_SelectedIndexChanged;
            // 
            // cbempName
            // 
            cbempName.FormattingEnabled = true;
            cbempName.Location = new Point(573, 12);
            cbempName.Name = "cbempName";
            cbempName.Size = new Size(215, 28);
            cbempName.TabIndex = 33;
            cbempName.SelectedIndexChanged += cbempName_SelectedIndexChanged;
            // 
            // txthours
            // 
            txthours.Location = new Point(573, 79);
            txthours.Name = "txthours";
            txthours.Size = new Size(215, 27);
            txthours.TabIndex = 32;
            txthours.TextChanged += txthours_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 86);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 31;
            label3.Text = "Hours";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 53);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 30;
            label2.Text = "ProjectName";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(452, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 29;
            label1.Text = "EmployeeName";
            label1.Click += label1_Click;
            // 
            // dvgListWorkOn
            // 
            dvgListWorkOn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListWorkOn.Location = new Point(12, 12);
            dvgListWorkOn.Name = "dvgListWorkOn";
            dvgListWorkOn.RowHeadersWidth = 51;
            dvgListWorkOn.RowTemplate.Height = 29;
            dvgListWorkOn.Size = new Size(434, 426);
            dvgListWorkOn.TabIndex = 28;
            dvgListWorkOn.CellDoubleClick += dvgListWorkOn_CellDoubleClick;
            // 
            // button3
            // 
            button3.Location = new Point(694, 135);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 27;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(573, 135);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 26;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(453, 135);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WorkOnManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbproName);
            Controls.Add(cbempName);
            Controls.Add(txthours);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgListWorkOn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "WorkOnManager";
            Text = "WorkOnManager";
            ((System.ComponentModel.ISupportInitialize)dvgListWorkOn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbproName;
        private ComboBox cbempName;
        private TextBox txthours;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dvgListWorkOn;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}