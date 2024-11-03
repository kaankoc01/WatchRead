using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        // UserRole ile olan ilişki
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
