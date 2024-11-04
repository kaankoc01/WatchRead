using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.RatingDto
{
    public class UpdateRatingDto
    {
        public int RatingId { get; set; } // Güncellenecek puanlama kaydının ID'si
        public decimal Score { get; set; } // Güncellenmiş puan
    }
}
