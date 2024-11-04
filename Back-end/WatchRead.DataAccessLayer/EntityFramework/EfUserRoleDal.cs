using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WatchRead.DataAccessLayer.Abstract;
using WatchRead.DataAccessLayer.Concrete;
using WatchRead.DataAccessLayer.Repositories;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.DataAccessLayer.EntityFramework
{
    public class EfUserRoleDal : GenericRepository<UserRole>, IUserRoleDal
    {
        public EfUserRoleDal(Context context) : base(context)
        {

        }

        public async Task<UserRole> GetAsync(Expression<Func<UserRole, bool>> filter)
        {
            // _dbSet, GenericRepository'den miras alınmış olduğu için burada kullanabiliriz.
            return await _dbSet.FirstOrDefaultAsync(filter);
        }
    }
}
