using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class ContentGenre
    {
        // içerik tür ilişkilendirmesi , bir içerik birden fazla türe sahip olduğunda kullanılacak.
        // Hem aksiyon ,  hem bilim kurgu gibi.

        public int ContentId { get; set; }
        public Content Content { get; set; } // İlişkiyi temsil eder

        public int GenreId { get; set; }
        public Genre Genre { get; set; } // İlişkiyi temsil eder
    }
}
