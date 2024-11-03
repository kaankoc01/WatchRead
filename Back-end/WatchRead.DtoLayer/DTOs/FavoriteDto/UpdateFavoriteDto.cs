using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.FavoriteDto
{
    public class UpdateFavoriteDto
    {
        public int Id { get; set; } // Güncellenecek favori kaydının ID'si
        public int ContentId { get; set; } // Favori olan içeriğin ID'si
    }
}
