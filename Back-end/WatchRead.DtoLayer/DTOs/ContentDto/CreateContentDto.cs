using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.ContentDto
{
    public class CreateContentDto
    {
        public string Title { get; set; } // İçeriğin başlığı
        public string Description { get; set; } // İçeriğin açıklaması
        public string Type { get; set; } // Bu alanı kontrol edin
        public DateTime ReleaseDate { get; set; } // İçeriğin yayın tarihi
        public int CategoryId { get; set; } // İçeriğin ait olduğu kategori ID'si
        public decimal Rating { get; set; } // İçeriğin genel puanı
    }
}
