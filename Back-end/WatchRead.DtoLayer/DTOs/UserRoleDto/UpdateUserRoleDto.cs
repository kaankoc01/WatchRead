using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.UserRoleDto
{
    public class UpdateUserRoleDto
    {
        public int UserId { get; set; } // Kullanıcının ID'si
        public int RoleId { get; set; } // Rolün ID'si
    }
}
