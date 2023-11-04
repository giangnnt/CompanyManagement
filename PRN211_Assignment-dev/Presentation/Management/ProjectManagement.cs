
using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.Management
{
    public partial class ProjectManagement : Form
    {
        private readonly ProjectRepository _proRepo;
        private readonly DepartmentRepository _departmentRepo;
        private readonly CompanyManagementContext _dbContext;
        public ProjectManagement()
        {
            InitializeComponent();
            _departmentRepo = new DepartmentRepository();
            _proRepo = new ProjectRepository();
            _dbContext = new CompanyManagementContext();
            GetAll();
        }
        private void ClearTextBox()
        {
            txtProNum.Text = string.Empty;
            txtProName.Text = string.Empty;
            txtProDepa.Text = string.Empty;
            txtProLoc.Text = string.Empty;
        }
        public void GetAll()
        {
            dataGridView1.DataSource = _proRepo.GetAll().Select(p => new
            {
                proNum = p.ProNum,
                proName = p.ProName,
                locNum = p.LocNum,
                depNum = p.DepNum,
                depName = p.DepNumNavigation.DepName,
                locName = p.LocNumNavigation.LocName
            }).ToList();
        }

        private void AddProject(object sender, EventArgs e)
        {
            try
            {
                var proNum = txtProNum.Text;
                var proName = txtProName.Text;
                var proDep = txtProDepa.Text;
                var proLoc = txtProLoc.Text;

                if (String.IsNullOrEmpty(proNum))
                {
                    throw new Exception("Project Number is missing");
                }
                if (String.IsNullOrEmpty(proName))
                {
                    throw new Exception("Project Name is missing");
                }
                if (String.IsNullOrEmpty(proDep))
                {
                    throw new Exception("Project Department is missing");
                }
                if (String.IsNullOrEmpty(proLoc))
                {
                    throw new Exception("Project Location is missing");
                }
                var proNumber = int.Parse(proNum);
                if (_dbContext.TblProjects.Find(proNumber) != null)
                {
                    throw new Exception("Project already exist");
                }

                int depNumber = int.Parse(proDep);
                var proDepartment = _dbContext.TblDepartments.Find(depNumber);
                if (proDepartment == null)
                {
                    throw new Exception("Department not exist");
                }

                int locNumber = int.Parse(proLoc);
                var proLocation = _dbContext.TblLocations.Find(locNumber);
                if (proLocation == null)
                {
                    throw new Exception("Location not exist");
                }
                var newProject = new TblProject()
                {
                    ProNum = int.Parse(proNum),
                    ProName = proName,
                    DepNum = int.Parse(proDep),
                    LocNum = int.Parse(proLoc),
                };
                _proRepo.Add(newProject);
                GetAll();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateProject(object sender, EventArgs e)
        {
            try
            {
                var proNum = txtProNum.Text;
                var proName = txtProName.Text;
                var proDep = txtProDepa.Text;
                var proLoc = txtProLoc.Text;

                if (String.IsNullOrEmpty(proNum))
                {
                    throw new Exception("Project Number is missing");
                }
                if (String.IsNullOrEmpty(proName))
                {
                    throw new Exception("Project Name is missing");
                }
                if (String.IsNullOrEmpty(proDep))
                {
                    throw new Exception("Project Department is missing");
                }
                if (String.IsNullOrEmpty(proLoc))
                {
                    throw new Exception("Project Location is missing");
                }
                var proNumber = int.Parse(proNum);

                int depNumber = int.Parse(proDep);
                var proDepartment = _dbContext.TblDepartments.Find(depNumber);
                if (proDepartment == null)
                {
                    throw new Exception("Department not exist");
                }

                int locNumber = int.Parse(proLoc);
                var proLocation = _dbContext.TblLocations.Find(locNumber);
                if (proLocation == null)
                {
                    throw new Exception("Location not exist");
                }

                var updateProject = _dbContext.TblProjects.Find(proNumber);
                if (updateProject == null)
                {
                    throw new Exception("Project not found");
                }
                updateProject.ProNum = int.Parse(proNum);
                updateProject.ProName = proName;
                updateProject.DepNum = int.Parse(proDep);
                updateProject.LocNum = int.Parse(proLoc);

                _proRepo.Update(updateProject);
                GetAll();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                var proNum = txtProNum.Text;
                var proNumber = int.Parse(proNum);
                var deleteProduct = _dbContext.TblProjects.Find(proNumber);
                result = MessageBox.Show("Do you want to delete ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _proRepo.Delete(deleteProduct);
                }
                GetAll();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtProNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtProName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtProDepa.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtProLoc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
