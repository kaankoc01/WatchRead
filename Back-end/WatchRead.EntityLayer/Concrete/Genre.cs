using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        // Genre ile ContentGenre arasındaki ilişki
        public ICollection<ContentGenre> ContentGenres { get; set; }
    }
}
