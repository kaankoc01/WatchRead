using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.ContentDto
{
    public class UpdateContentDto
    {
        public int ContentId { get; set; } // Güncellenecek içeriğin ID'si
        public string Title { get; set; } // Güncellenmiş başlık
        public string Description { get; set; } // Güncellenmiş açıklama
    }
}
