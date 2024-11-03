using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.RatingDto
{
    public class ResultRatingDto
    {
        public int Id { get; set; } // Puanlama kaydının ID'si
        public int UserId { get; set; } // Puanı veren kullanıcının ID'si
        public int ContentId { get; set; } // Puanlanan içeriğin ID'si
        public decimal Score { get; set; } // Verilen puan
    }
}
