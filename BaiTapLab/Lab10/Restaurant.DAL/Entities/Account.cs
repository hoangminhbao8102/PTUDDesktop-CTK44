using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class Account
    {
        public string AccountName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Tell { get; set; }

        public DateTime? DateCreated { get; set; }

        public ICollection<RoleAccount>? RoleAccounts { get; set; }
    }
}
