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
    public partial class EmployeeDetails : Form
    {
        private readonly decimal empID;
        private DependentRepository dependentRepository;
        private WorksOnRepository worksOnRepository;
        private EmployeeRepository employeeRepository;

        public EmployeeDetails(decimal empID)
        {
            InitializeComponent();

            this.empID = empID;
            dependentRepository = new DependentRepository();
            worksOnRepository = new WorksOnRepository();
            employeeRepository = new EmployeeRepository();

            RenderView();
        }

        private void RenderView()
        {
            var dependentList = dependentRepository.GetAll()
                                                   .Where(d => d.EmpSsn == empID)
                                                   .ToList();
            dgvDependent.DataSource = dependentList;

            var worksOnList = worksOnRepository.GetAll()
                                               .Include(wo => wo.ProNumNavigation)
                                               .Where(wo => wo.EmpSsn == empID)
                                               .Select(wo => new
                                               {
                                                   ProNum = wo.ProNum,
                                                   ProName = wo.ProNumNavigation.ProName,
                                                   WorkHours = wo.WorkHours,
                                               })
                                               .ToList();
            dgvWorksOn.DataSource = worksOnList;

            var baseSalary = employeeRepository.GetAll()
                                               .Where(e => e.EmpSsn == empID)
                                               .Select(e => e.EmpSalary)
                                               .FirstOrDefault();

            var salary = worksOnList.Sum(wo => wo.WorkHours) * baseSalary;
            lbSalary.Text = string.Format("{0:N0} VND", salary);

            txtID.Text = empID.ToString();
        }
    }
}
