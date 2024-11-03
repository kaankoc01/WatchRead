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
        public DateTime ReleasedDate { get; set; } // İçeriğin yayın tarihi
    }
}
