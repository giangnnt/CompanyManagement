using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using ElectricStore_StudentName;

namespace Presentation
{
    public partial class Register : Form
    {
        private UserRepository userRepository;

        public Register()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing require field", "Error");
                return;
            }

            var user = userRepository.GetAll()
                        .Where(u => u.UserName.Equals(username) && u.Password.Equals(password))
                        .FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Account is already exist!", "Error");
                return;
            }

            // Account not exist, add new one
            try
            {
                userRepository.Add(new TblUser
                {
                    UserName = username,
                    Password = password,
                    Role = "Staff"
                });

                MessageBox.Show("Register successfully", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
