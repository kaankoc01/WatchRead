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
    public class FavoriteManager : GenericManager<Favorite> , IFavoriteService
    {
        private readonly IFavoriteDal _favoriteDal;

        public FavoriteManager(IFavoriteDal favoriteDal) :base(favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }
    }
}
