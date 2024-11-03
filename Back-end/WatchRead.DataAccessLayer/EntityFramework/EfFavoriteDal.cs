using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.DataAccessLayer.Abstract;
using WatchRead.DataAccessLayer.Concrete;
using WatchRead.DataAccessLayer.Repositories;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.DataAccessLayer.EntityFramework
{
    public class EfFavoriteDal : GenericRepository<Favorite>, IFavoriteDal
    {
        public EfFavoriteDal(Context context) : base(context)
        {
        }
    }
}
