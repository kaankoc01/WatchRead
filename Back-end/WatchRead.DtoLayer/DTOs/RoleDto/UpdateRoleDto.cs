using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.RoleDto
{
    public class UpdateRoleDto
    {
        public int RoleId { get; set; } // Güncellenecek rolün ID'si
        public string RoleName { get; set; } // Güncellenmiş rol adı
    }
}
