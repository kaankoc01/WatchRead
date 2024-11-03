using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class Favorite
    {
        public int FavoriteId { get; set; }
        public int UserId { get; set; }
        public int ContentId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
