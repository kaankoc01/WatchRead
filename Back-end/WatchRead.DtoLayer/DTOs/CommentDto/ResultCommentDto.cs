using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.CommentDto
{
    public class ResultCommentDto
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Yorum yapan kullanıcının ID'si
        public int ContentId { get; set; } // Yorumun ait olduğu içeriğin ID'si
        public string Text { get; set; } // Yorum metni
        public DateTime CreatedAt { get; set; } // Yorumun oluşturulma tarihi
    }
}
