namespace ElectricStore_StudentName
{
    partial class Login
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
            lbUserName = new Label();
            txtUserName = new TextBox();
            lbLogin = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            btnLogin = new Button();
            label1 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.Location = new Point(255, 158);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(99, 28);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(360, 155);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(176, 34);
            txtUserName.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogin.ForeColor = SystemColors.HotTrack;
            lbLogin.Location = new Point(323, 39);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(133, 46);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "Login";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(360, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 34);
            txtPassword.TabIndex = 4;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(255, 208);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(93, 28);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(442, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(214, 357);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 6;
            label1.Text = "Don't Have an Account?";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(442, 350);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 43);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(lbLogin);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private TextBox txtUserName;
        private Label lbLogin;
        private TextBox txtPassword;
        private Label lbPassword;
        private Button btnLogin;
        private Label label1;
        private Button btnRegister;
    }
}