using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchRead.EntityLayer.Concrete
{
    public class ContentGenre
    {
        // içerik tür ilişkilendirmesi , bir içerik birden fazla türe sahip olduğunda kullanılacak. Hem aksiyon
        // hem bilim kurgu gibi.
        public int ContentId { get; set; }
        public int GenreId { get; set; }
    }
}
