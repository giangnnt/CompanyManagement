using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblProject
    {
        public TblProject()
        {
            TblWorksOns = new HashSet<TblWorksOn>();
        }

        public int ProNum { get; set; }
        public string ProName { get; set; }
        public int? LocNum { get; set; }
        public int? DepNum { get; set; }

        public virtual TblDepartment DepNumNavigation { get; set; }
        public virtual TblLocation LocNumNavigation { get; set; }
        public virtual ICollection<TblWorksOn> TblWorksOns { get; set; }
    }
}
