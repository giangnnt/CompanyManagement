using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblDependent
    {
        public string DepName { get; set; }
        public decimal EmpSsn { get; set; }
        public string DepSex { get; set; }
        public DateTime? DepBirthdate { get; set; }
        public string DepRelationship { get; set; }

        public virtual TblEmployee EmpSsnNavigation { get; set; }
    }
}
