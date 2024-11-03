using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.UserDto
{
    public class UpdateUserDto
    {
        public int Id { get; set; } // Güncellenecek kullanıcının ID'si
        public string Username { get; set; } // Güncellenmiş kullanıcı adı
        public string Email { get; set; } // Güncellenmiş e-posta adresi
    }
}
