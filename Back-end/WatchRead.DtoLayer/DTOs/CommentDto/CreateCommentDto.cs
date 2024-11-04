using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.DtoLayer.DTOs.CommentDto
{
    public class CreateCommentDto
    {
        public int UserId { get; set; }
        public int ContentId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
