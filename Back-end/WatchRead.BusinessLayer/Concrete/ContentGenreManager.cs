using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DataAccessLayer.Abstract;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.BusinessLayer.Concrete
{
    public class ContentGenreManager : GenericManager<ContentGenre> , IContentGenreService
    {
        private readonly IContentGenreDal _contentGenreDal;

        public ContentGenreManager(IContentGenreDal contentGenreDal) :base(contentGenreDal) 
        {
            _contentGenreDal = contentGenreDal;
        }
    }
}
