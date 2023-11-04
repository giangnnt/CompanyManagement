using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblLocation
    {
        public TblLocation()
        {
            TblDepLocations = new HashSet<TblDepLocation>();
            TblProjects = new HashSet<TblProject>();
        }

        public int LocNum { get; set; }
        public string LocName { get; set; }

        public virtual ICollection<TblDepLocation> TblDepLocations { get; set; }
        public virtual ICollection<TblProject> TblProjects { get; set; }
    }
}
