using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblDepLocation
    {
        public int DepNum { get; set; }
        public int LocNum { get; set; }

        public virtual TblDepartment DepNumNavigation { get; set; }
        public virtual TblLocation LocNumNavigation { get; set; }
    }
}
