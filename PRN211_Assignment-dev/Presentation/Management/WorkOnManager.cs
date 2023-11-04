using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
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
    public partial class WorkOnManager : Form
    {
        private WorksOnRepository WorksOnRepository;
        private ProjectRepository ProjectRepository;
        private EmployeeRepository EmployeeRepository;
        public WorkOnManager()
        {
            InitializeComponent();
            WorksOnRepository = new WorksOnRepository();
            LoadTable();

        }
        public void LoadTable()
        {
            var list = WorksOnRepository.GetAll().ToList();
            dvgListWorkOn.DataSource = list;



        }
        private void cbempName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbproName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txthours_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            string empName = cbempName.Text;
            string proName = cbproName.Text;

            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(proName))
            {
                MessageBox.Show("Please select an employee and a project.");
                return;
            }

            var selectedEmployee = EmployeeRepository.GetAll().FirstOrDefault(e => e.EmpName == empName);
            var selectedProject = ProjectRepository.GetAll().FirstOrDefault(p => p.ProName == proName);

            if (selectedEmployee == null || selectedProject == null)
            {
                MessageBox.Show("Employee or Project not found");
                return;
            }

            decimal empSsn = selectedEmployee.EmpSsn;
            int proNum = selectedProject.ProNum;

            var context = new CompanyManagementContext();

            var existingEntity = context.TblWorksOns.Find(empSsn, proNum);

            if (existingEntity != null)
            {
                try
                {
                    context.TblWorksOns.Remove(existingEntity);
                    context.SaveChanges();
                    LoadTable();
                    MessageBox.Show("TblWorksOn deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Record not found for deletion.");
            }



        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            string empName = cbempName.Text;
            string proName = cbproName.Text;


            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(proName))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên và một dự án.");
                return;
            }

            if (!int.TryParse(txthours.Text, out int hours))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ cho giờ làm việc.");
                return;
            }

            var selectedEmployee = EmployeeRepository.GetAll().FirstOrDefault(e => e.EmpName == empName);
            var selectedProject = ProjectRepository.GetAll().FirstOrDefault(p => p.ProName == proName);
            if (selectedEmployee == null || selectedProject == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên hoặc dự án đã chọn trong nguồn dữ liệu.");
                return;
            }

            decimal empSsn = selectedEmployee.EmpSsn;
            int proNum = selectedProject.ProNum;


            using (var context = new CompanyManagementContext())
            {
                var existingEntity = context.TblWorksOns.Find(empSsn, proNum);

                if (existingEntity != null)
                {
                    existingEntity.WorkHours = hours;

                    try
                    {

                        context.SaveChanges();
                        LoadTable();

                        MessageBox.Show("Bản ghi TblWorksOn đã được cập nhật thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi để cập nhật.");
                }
            }
        }
        //create 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string empName = cbempName.Text;
                string proName = cbproName.Text;

                if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(proName))
                {
                    MessageBox.Show("Please select an employee and a project.");
                    return;
                }

                if (!int.TryParse(txthours.Text, out int hours))
                {
                    MessageBox.Show("Please enter a valid integer for work hours.");
                    return;
                }

                var selectedEmployee = EmployeeRepository.GetAll().FirstOrDefault(e => e.EmpName == empName);
                var selectedProject = ProjectRepository.GetAll().FirstOrDefault(p => p.ProName == proName);
                if (selectedEmployee == null || selectedProject == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên hoặc dự án đã chọn trong nguồn dữ liệu.");
                    return;
                }

                decimal empSsn = selectedEmployee.EmpSsn;
                int proNum = selectedProject.ProNum;
                var context = new CompanyManagementContext();

                var workOn = new TblWorksOn
                {
                    EmpSsn = empSsn,
                    ProNum = proNum,
                    WorkHours = hours
                };

                context.TblWorksOns.Add(workOn);
                context.SaveChanges();

                LoadTable();
                MessageBox.Show("TblWorksOn created successfully.");
            }
            catch (DbUpdateException ex)
            {
                // If there's a database-related error, you can get more details from ex.InnerException
                MessageBox.Show("A database error occurred: " + ex.InnerException?.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadtbProject()
        {
            var listProjectName = ProjectRepository.GetAll().Select(p => new { value = p.ProNum, text = p.ProName }).ToList();
            cbproName.ValueMember = "value";
            cbproName.DisplayMember = "text";
            cbproName.DataSource = listProjectName;
        }

        private void LoadtbEmployeeName()
        {
            var listEmployeeName = EmployeeRepository.GetAll().Select(p => new { value = p.EmpSsn, text = p.EmpName }).ToList();
            cbempName.ValueMember = "value";
            cbempName.DisplayMember = "text";
            cbempName.DataSource = listEmployeeName;
        }

        private void dvgListWorkOn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectRepository = new ProjectRepository();
            EmployeeRepository = new EmployeeRepository();
            LoadtbProject();
            LoadtbEmployeeName();
            var row = dvgListWorkOn.Rows[e.RowIndex];
            cbempName.SelectedValue = row.Cells[0].Value;
            cbproName.SelectedValue = row.Cells[1].Value;
            txthours.Text = row.Cells[2].Value.ToString();
            LoadTable();
        }
    }
}
