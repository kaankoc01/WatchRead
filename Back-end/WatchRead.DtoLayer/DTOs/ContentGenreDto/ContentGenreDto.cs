using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.ContentGenreDto
{
    public class ContentGenreDto
    {
        public int ContentId { get; set; } // İlişkilendirilen içeriğin ID'si
        public int GenreId { get; set; } // İlişkilendirilen türün ID'si
    }
}

