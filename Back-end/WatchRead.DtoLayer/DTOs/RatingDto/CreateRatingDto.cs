using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.RatingDto
{
    public class CreateRatingDto
    {
        public int UserId { get; set; } // Puanı veren kullanıcının ID'si
        public int ContentId { get; set; } // Puanlanan içeriğin ID'si
        public decimal Score { get; set; } // Verilen puan
    }
}
