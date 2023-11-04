namespace Presentation
{
    partial class Register
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            lbPassword = new Label();
            lbLogin = new Label();
            txtUserName = new TextBox();
            lbUserName = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(467, 272);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 43);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(385, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 34);
            txtPassword.TabIndex = 12;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(280, 217);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(93, 28);
            lbPassword.TabIndex = 11;
            lbPassword.Text = "Password";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogin.ForeColor = SystemColors.HotTrack;
            lbLogin.Location = new Point(348, 48);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(180, 46);
            lbLogin.TabIndex = 10;
            lbLogin.Text = "Sign Up";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(385, 164);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(176, 34);
            txtUserName.TabIndex = 9;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.Location = new Point(280, 167);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(99, 28);
            lbUserName.TabIndex = 8;
            lbUserName.Text = "Username";
            // 
            // Register
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(lbLogin);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private Label lbPassword;
        private Label lbLogin;
        private TextBox txtUserName;
        private Label lbUserName;
    }
}