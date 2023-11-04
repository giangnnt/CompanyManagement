using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Presentation.Management
{
    public partial class DependentManagement : Form
    {
        private EmployeeRepository employeeRepository;
        private DependentRepository dependentRepository;
        private string tempDepName { set; get; } = "";

        public DependentManagement()
        {
            InitializeComponent();

            employeeRepository = new EmployeeRepository();
            dependentRepository = new DependentRepository();

            var genderList = new object[] { "M", "F" };
            cbdepSex.Items.AddRange(genderList);

            var relationList = new object[] { "Cha", "Mẹ", "Chồng", "Vợ", "Anh", "Chị", "Em", "Con" };
            cbdepRelationship.Items.AddRange(relationList);

            RenderView();
        }
        private void RenderView()
        {
            var list = dependentRepository.GetAll()
                                         .Include(e => e.EmpSsnNavigation)
                                         .Select(e => new
                                         {
                                             DependentName = e.DepName,
                                             EmployeeID = e.EmpSsnNavigation.EmpSsn,
                                             Gender = e.DepSex,
                                             BirthDate = e.DepBirthdate,
                                             Relationship = e.DepRelationship,
                                         })
                                         .ToList();
            dgvInfor.DataSource = list;

            bool enable = String.IsNullOrEmpty(txtempSSN.Text);

            btnAdd.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnUpdate.Enabled = !enable;

            txtempSSN.ReadOnly = !enable;
        }

        private void EmptyText()
        {
            txtdepName.Text = "";
            txtempSSN.Text = "";

        }

        private void dgvInfor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfor.Rows[e.RowIndex];
            txtdepName.Text = row.Cells[0].Value.ToString();
            txtempSSN.Text = row.Cells[1].Value.ToString();
            cbdepSex.Text = row.Cells[2].Value.ToString();
            dtpBirthDate.Value = (DateTime)row.Cells[3].Value;
            cbdepRelationship.Text = row.Cells[4].Value?.ToString();

            tempDepName = txtdepName.Text ?? "";

            RenderView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var depname = txtdepName.Text;
            var empid = txtempSSN.Text;
            var gender = cbdepSex.Text;
            var birthDate = dtpBirthDate.Value;
            var depRela = cbdepRelationship.Text;

            try
            {
                if (String.IsNullOrEmpty(empid))
                {
                    throw new Exception("Missing empid field");
                }

                if (String.IsNullOrEmpty(depname))
                {
                    throw new Exception("Missing dependent name");
                }

                var curEmp = dependentRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(empid))
                                                .FirstOrDefault();

                var curDep = dependentRepository.GetAll()
                                                .Where(e => e.DepName.Equals(depname))
                                                .FirstOrDefault();
                if (curEmp != null)
                {
                    throw new Exception("Employee not found");
                }

                if (curDep != null)
                {
                    throw new Exception("Dependent Name existed");
                }

                var dep = new TblDependent()
                {
                    DepName = depname,
                    EmpSsn = decimal.Parse(empid),
                    DepSex = gender,
                    DepBirthdate = birthDate.Date,
                    DepRelationship = depRela
                };

                dependentRepository.Add(dep);
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
            var depname = txtdepName.Text;
            var empid = txtempSSN.Text;
            var gender = cbdepSex.Text;
            var birthDate = dtpBirthDate.Value;
            var depRela = cbdepRelationship.Text;

            try
            {
                var curDep = dependentRepository.GetAll()
                                                .Where(e => e.DepName.Equals(tempDepName) && e.EmpSsn == decimal.Parse(empid))
                                                .First();

                // Cannot update directly as cannot modify key, delete first
                dependentRepository.Delete(curDep);

                var dep = new TblDependent();
                dep.DepName = depname;
                dep.EmpSsn = decimal.Parse(empid);
                dep.DepSex = gender;
                dep.DepBirthdate = birthDate.Date;
                dep.DepRelationship = depRela;

                dependentRepository.Add(dep);

                tempDepName = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            EmptyText();
            RenderView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var depName = txtdepName.Text;
            var empID = decimal.Parse(txtempSSN.Text);

            var curDep = dependentRepository.GetAll()
                                                .Where(e => e.EmpSsn == empID && e.DepName.Equals(depName))
                                                .First();

            if (curDep == null)
            {
                MessageBox.Show("Dependent not found", "Error");
                return;
            }

            dependentRepository.Delete(curDep);

            EmptyText();
            RenderView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmptyText();
            RenderView();
        }
    }
}
