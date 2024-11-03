using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.GenreDto
{
    public class UpdateGenreDto
    {
        public int Id { get; set; } // Güncellenecek türün ID'si
        public string Name { get; set; } // Güncellenmiş tür adı
    }
}
