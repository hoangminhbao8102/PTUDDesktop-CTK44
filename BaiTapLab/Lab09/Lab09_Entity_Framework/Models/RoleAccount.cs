﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class RoleAccount
    {
        public int RoleId { get; set; }

        public string? AccountName { get; set; }

        public bool Actived { get; set; }

        public string? Notes { get; set; }

        public Role? Role { get; set; }

        public Account? Account { get; set; }
    }
}
