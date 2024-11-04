using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.DataAccessLayer.Abstract;
using WatchRead.DataAccessLayer.Concrete;
using WatchRead.DataAccessLayer.EntityFramework;
using WatchRead.DataAccessLayer.Repositories;

namespace WatchRead.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public IGenericDal<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync(); // Değişiklikleri kaydet
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
