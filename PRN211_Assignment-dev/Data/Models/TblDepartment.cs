using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblDepLocations = new HashSet<TblDepLocation>();
            TblEmployees = new HashSet<TblEmployee>();
            TblProjects = new HashSet<TblProject>();
        }

        public int DepNum { get; set; }
        public string DepName { get; set; }
        public decimal? MgrSsn { get; set; }
        public DateTime? MgrAssDate { get; set; }

        public virtual TblEmployee MgrSsnNavigation { get; set; }
        public virtual ICollection<TblDepLocation> TblDepLocations { get; set; }
        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
        public virtual ICollection<TblProject> TblProjects { get; set; }
    }
}
