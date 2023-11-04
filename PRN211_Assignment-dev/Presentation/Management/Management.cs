using Data.Models;
using Data.Repository;
using ElectricStore_StudentName;
using Microsoft.EntityFrameworkCore;
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

namespace Presentation.Management
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void ShowForm(Form form)
        {
            form.FormClosing += (sender, e) => this.Show();

            this.Hide();
            form.Show();
        }

        private void btnAccountMgt_Click(object sender, EventArgs e)
        {
            ShowForm(new AccountManagement());
        }

        private void btnEmployeeMgt_Click(object sender, EventArgs e)
        {
            ShowForm(new EmployeeManagement());
        }

        private void btnProjectMgt_Click_1(object sender, EventArgs e)
        {
            ShowForm(new ProjectManagement());
        }

        private void btnWorksOnMgt_Click(object sender, EventArgs e)
        {
            ShowForm (new WorkOnManager ());    
        }

        private void btnDependentMgt_Click(object sender, EventArgs e)
        {
            ShowForm(new DependentManagement());
        }
    }
}
