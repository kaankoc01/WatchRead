using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.UserDto
{
    public class CreateUserDto
    {
        public string Username { get; set; } // Kullanıcı adı
        public string Email { get; set; } // Kullanıcı e-posta adresi
        public string Password { get; set; } // Kullanıcı şifresi
    }
}
