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
    public class UserManager : GenericManager<User> ,IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal): base(userDal) 
        {
            _userDal = userDal;
        }
    }
}
