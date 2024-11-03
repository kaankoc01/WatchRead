using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int ContentId { get; set; }
        public decimal Score { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigasyon özellikleri
        public User User { get; set; }
        public Content Content { get; set; }
    }
}
