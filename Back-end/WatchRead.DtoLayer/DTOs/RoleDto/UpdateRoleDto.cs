using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.RoleDto
{
    public class UpdateRoleDto
    {
        public int Id { get; set; } // Güncellenecek rolün ID'si
        public string Name { get; set; } // Güncellenmiş rol adı
    }
}
