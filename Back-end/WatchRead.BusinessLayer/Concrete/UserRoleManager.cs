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
    public class UserRoleManager : GenericManager<UserRole> , IUserRoleService
    {
        private readonly IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal) :base(userRoleDal) 
        {
            _userRoleDal = userRoleDal;
        }
        public async Task<UserRole> TGetByUserIdAndRoleIdAsync(int userId, int roleId)
        {
            return await _userRoleDal.GetAsync(ur => ur.UserId == userId && ur.RoleId == roleId);
        }
    }
}
