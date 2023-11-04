using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Management
{
    public partial class EmployeeManagement : Form
    {
        private EmployeeRepository employeeRepository;
        private DepartmentRepository departmentRepository;

        public EmployeeManagement()
        {
            InitializeComponent();

            employeeRepository = new EmployeeRepository();
            departmentRepository = new DepartmentRepository();

            var genderList = new object[] { "M", "F" };
            cbGender.Items.AddRange(genderList);

            var depList = departmentRepository.GetAll()
                                              .Select(d => d.DepNum.ToString())
                                              .ToArray();
            cbDepNum.Items.AddRange(depList);

            var statusList = new object[] { true, false };
            cbStatus.Items.AddRange(statusList);

            RenderView();
        }

        private void RenderView()
        {
            var list = employeeRepository.GetAll()
                                         .Include(e => e.DepNumNavigation)
                                         .Select(e => new
                                         {
                                             ID = e.EmpSsn,
                                             Name = e.EmpName,
                                             Address = e.EmpAddress,
                                             Salary = e.EmpSalary,
                                             Gender = e.EmpSex,
                                             BirthDate = e.EmpBirthdate,
                                             DepNum = e.DepNum,
                                             DepLocation = e.DepNumNavigation.DepName,
                                             SupervisorID = e.SupervisorSsn,
                                             StartDate = e.EmpStartdate,
                                             Active = e.Active,
                                         })
                                         .ToList();
            dgvInfo.DataSource = list;

            bool enable = String.IsNullOrEmpty(txtID.Text);

            btnAdd.Enabled = enable;
            btnUpdate.Enabled = !enable;
            btnDetail.Enabled = !enable;

            txtID.ReadOnly = !enable;
        }

        private void EmptyText()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
            txtSupervisorID.Text = "";
        }

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfo.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtSalary.Text = row.Cells[3].Value?.ToString();
            cbGender.Text = row.Cells[4].Value.ToString();
            dtpBirthDate.Value = (DateTime)row.Cells[5].Value;
            cbDepNum.Text = row.Cells[6].Value?.ToString();
            txtSupervisorID.Text = row.Cells[8].Value?.ToString();
            dtpStartDate.Value = (DateTime)row.Cells[9].Value;
            cbStatus.Text = row.Cells[10].Value?.ToString();

            RenderView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var name = txtName.Text;
            var address = txtAddress.Text;
            var salary = txtSalary.Text;
            var gender = cbGender.Text;
            var birthDate = dtpBirthDate.Value;
            var depNum = cbDepNum.Text;
            var supervisorID = txtSupervisorID.Text;
            var startDate = dtpStartDate.Value;

            try
            {
                if (String.IsNullOrEmpty(id))
                {
                    throw new Exception("Missing id field");
                }

                if (startDate > DateTime.Now)
                {
                    throw new Exception("startDate invalid");
                }

                if (DateTime.Now.Year - birthDate.Year < 18)
                {
                    throw new Exception("Employee must be at least 18 years old");
                }

                var curEmp = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(id))
                                                .FirstOrDefault();

                if (curEmp != null)
                {
                    throw new Exception("Employee ID existed");
                }

                var emp = new TblEmployee()
                {
                    EmpSsn = decimal.Parse(id),
                    EmpName = name,
                    EmpAddress = address,
                    EmpSalary = !String.IsNullOrEmpty(salary) ? decimal.Parse(salary) : null,
                    EmpSex = gender,
                    EmpBirthdate = birthDate.Date,
                    DepNum = !String.IsNullOrEmpty(depNum) ? int.Parse(depNum) : null,
                    SupervisorSsn = !String.IsNullOrEmpty(supervisorID) ? decimal.Parse(supervisorID) : null,
                    EmpStartdate = startDate.Date
                };

                employeeRepository.Add(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            EmptyText();
            RenderView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var name = txtName.Text;
            var address = txtAddress.Text;
            var salary = txtSalary.Text;
            var gender = cbGender.Text;
            var birthDate = dtpBirthDate.Value;
            var depNum = cbDepNum.Text;
            var supervisorID = txtSupervisorID.Text;
            var startDate = dtpStartDate.Value;
            var active = cbStatus.Text;

            try
            {
                if (startDate > DateTime.Now)
                {
                    throw new Exception("startDate invalid");
                }

                if (DateTime.Now.Year - birthDate.Year < 18)
                {
                    throw new Exception("Employee must be at least 18 years old");
                }

                var curEmp = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(id))
                                                .First();

                if (curEmp == null)
                {
                    throw new Exception("Employee ID not found");
                }

                curEmp.EmpSsn = decimal.Parse(id);
                curEmp.EmpName = name;
                curEmp.EmpAddress = address;
                curEmp.EmpSalary = !String.IsNullOrEmpty(salary) ? decimal.Parse(salary) : null;
                curEmp.EmpSex = gender;
                curEmp.EmpBirthdate = birthDate.Date;
                curEmp.DepNum = !String.IsNullOrEmpty(depNum) ? int.Parse(depNum) : null;
                curEmp.SupervisorSsn = !String.IsNullOrEmpty(supervisorID) ? decimal.Parse(supervisorID) : null;
                curEmp.EmpStartdate = startDate.Date;
                curEmp.Active = bool.Parse(active);

                employeeRepository.Update(curEmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            EmptyText();
            RenderView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmptyText();
            RenderView();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var form = new EmployeeDetails(decimal.Parse(txtID.Text));

            form.Show();
        }

    }
}
