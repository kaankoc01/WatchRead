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
    public class RatingManager : GenericManager<Rating>,IRatingService
    {
        private readonly IRatingDal _ratingDal;

        public RatingManager(IRatingDal ratingDal) :base(ratingDal) 
        {
            _ratingDal = ratingDal;
        }
    }
}
