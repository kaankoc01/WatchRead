using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.CommentDto
{
    public class UpdateCommentDto
    {
        public int Id { get; set; } // Güncellenecek yorumun ID'si
        public string Text { get; set; } // Güncellenmiş yorum metni
    }
}
