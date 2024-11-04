using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.DataAccessLayer.Abstract;

namespace WatchRead.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericDal<T> GetRepository<T>() where T : class; // Generic repository döndüren metod
        Task<int> SaveChangesAsync(); // Değişiklikleri kaydetmek için
    }
}
