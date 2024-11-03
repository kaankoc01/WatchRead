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
    public class RoleManager : GenericManager<Role>,IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal) :base(roleDal) 
        {
            _roleDal = roleDal;
        }
    }
}
