using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        public decimal Rating { get; set; }
    }
}
