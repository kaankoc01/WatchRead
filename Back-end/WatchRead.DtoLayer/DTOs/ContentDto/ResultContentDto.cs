using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.ContentDto
{
    public class ResultContentDto
    {
        public int ContentId { get; set; }
        public string Title { get; set; } // İçeriğin başlığı
        public string Description { get; set; } // İçeriğin açıklaması
        public decimal Rating { get; set; } // İçeriğin genel puanı
        public string Type { get; set; } // Bu alanı kontrol edin
        public DateTime ReleasedDate { get; set; } // İçeriğin yayın tarihi
    }
}
