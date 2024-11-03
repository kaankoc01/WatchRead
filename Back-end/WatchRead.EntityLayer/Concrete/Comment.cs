using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int ContentId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
