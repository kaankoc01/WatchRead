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

        // Category ile olan ilişki
        public Category Category { get; set; } // Category nesnesinin referansı

        // Content ile ContentGenre arasındaki ilişki
        public ICollection<ContentGenre> ContentGenres { get; set; }

        // Navigasyon özellikleri
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();

        
    }
}
