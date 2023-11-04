using Data;
using Data.Repository;
using Microsoft.VisualBasic.Logging;
using Presentation;
using Presentation.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_StudentName
{
    public partial class Login : Form
    {
        private UserRepository userRepository;

        public Login()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

        private void ShowForm(Form form)
        {
            form.FormClosing += (sender, e) => this.Show();

            this.Hide();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;

            var user = userRepository.GetAll()
                        .Where(u => u.UserName.Equals(username) && u.Password.Equals(password))
                        .FirstOrDefault();

            if (user != null)
            {
                if (user.Role.Equals("Admin"))
                {
                    ShowForm(new Management());
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ShowForm(new Register());
        }
    }
}
