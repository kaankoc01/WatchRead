using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Content ile olan 1'e çok ilişkiyi tanımlayan koleksiyon
        public ICollection<Content> Contents { get; set; } = new List<Content>();
    }
}
