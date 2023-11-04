using Data.Models;
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
using System.Xml.Linq;

namespace Presentation.Management
{
    public partial class AccountManagement : Form
    {
        private UserRepository accountRepository;

        public AccountManagement()
        {
            InitializeComponent();

            accountRepository = new UserRepository();
            RenderView();
        }

        private void RenderView()
        {
            var list = accountRepository.GetAll().ToList();
            dgvInfo.DataSource = list;

            bool enable = String.IsNullOrEmpty(txtUserName.Text);

            btnAdd.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnUpdate.Enabled = !enable;

            txtUserName.ReadOnly = !enable;
            txtPassword.ReadOnly = !enable;            
        }

        private void EmptyText()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfo.Rows[e.RowIndex];

            var username = row.Cells[0].Value.ToString();
            var password = row.Cells[1].Value.ToString();
            var role = row.Cells[2].Value.ToString();

            txtUserName.Text = username;
            txtPassword.Text = password;
            txtRole.Text = role;

            RenderView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;
            var role = txtRole.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing required field", "Error");
                return;
            }

            var curAccount = accountRepository.GetAll()
                                            .Where(a => a.UserName == username)
                                            .First();

            if (curAccount != null)
            {
                MessageBox.Show("Account existed", "Error");
                return;
            }

            try
            {
                var account = new TblUser();
                account.UserName = username;
                account.Password = password;
                account.Role = role;

                accountRepository.Add(account);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            EmptyText();
            RenderView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;
            var role = txtRole.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing required field", "Error");
                return;
            }

            var curAccount = accountRepository.GetAll()
                                            .Where(a => a.UserName == username)
                                            .FirstOrDefault();

            if (curAccount == null)
            {
                MessageBox.Show("UserName not found", "Error");
                return;
            }

            curAccount.UserName = username;
            curAccount.Password = password;
            curAccount.Role = role;

            accountRepository.Update(curAccount);

            EmptyText();
            RenderView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;

            var curAccount = accountRepository.GetAll()
                                            .Where(a => a.UserName == username)
                                            .First();

            if (curAccount != null)
            {
                accountRepository.Delete(curAccount);
            }

            EmptyText();
            RenderView();
        }
    }
}
