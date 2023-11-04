using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblEmployee
    {
        public TblEmployee()
        {
            InverseSupervisorSsnNavigation = new HashSet<TblEmployee>();
            TblDepartments = new HashSet<TblDepartment>();
            TblDependents = new HashSet<TblDependent>();
            TblWorksOns = new HashSet<TblWorksOn>();
        }

        public decimal EmpSsn { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public decimal? EmpSalary { get; set; }
        public string EmpSex { get; set; }
        public DateTime? EmpBirthdate { get; set; }
        public int? DepNum { get; set; }
        public decimal? SupervisorSsn { get; set; }
        public DateTime? EmpStartdate { get; set; }
        public bool? Active { get; set; }

        public virtual TblDepartment DepNumNavigation { get; set; }
        public virtual TblEmployee SupervisorSsnNavigation { get; set; }
        public virtual ICollection<TblEmployee> InverseSupervisorSsnNavigation { get; set; }
        public virtual ICollection<TblDepartment> TblDepartments { get; set; }
        public virtual ICollection<TblDependent> TblDependents { get; set; }
        public virtual ICollection<TblWorksOn> TblWorksOns { get; set; }
    }
}
