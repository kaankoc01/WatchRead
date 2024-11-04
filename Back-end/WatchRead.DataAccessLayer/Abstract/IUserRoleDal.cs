using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.DataAccessLayer.Abstract
{
    public interface IUserRoleDal : IGenericDal<UserRole>
    {
        Task<UserRole> GetAsync(Expression<Func<UserRole, bool>> filter);
    }
}
