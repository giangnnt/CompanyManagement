﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class TblUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
