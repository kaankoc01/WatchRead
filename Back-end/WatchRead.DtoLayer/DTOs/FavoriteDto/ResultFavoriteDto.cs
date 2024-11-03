using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.FavoriteDto
{
    public class ResultFavoriteDto
    {
        public int Id { get; set; } // Favori kaydının ID'si
        public int UserId { get; set; } // Favori olan kullanıcının ID'si
        public int ContentId { get; set; } // Favori olan içeriğin ID'si
        public DateTime AddedAt { get; set; } // Favoriye eklenme tarihi
    }
}
