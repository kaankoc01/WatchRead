using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.UserDto
{
    public class ResultUserDto
    {
        public int UserId { get; set; } // Kullanıcının ID'si
        public string Username { get; set; } // Kullanıcı adı
        public string Email { get; set; } // Kullanıcı e-posta adresi
    }
}
