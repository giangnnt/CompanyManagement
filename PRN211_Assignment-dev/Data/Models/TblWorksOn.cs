using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblWorksOn
    {
        public decimal EmpSsn { get; set; }
        public int ProNum { get; set; }
        public int? WorkHours { get; set; }

        public virtual TblEmployee EmpSsnNavigation { get; set; }
        public virtual TblProject ProNumNavigation { get; set; }
    }
}
