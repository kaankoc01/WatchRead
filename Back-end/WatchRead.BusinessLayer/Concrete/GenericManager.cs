using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DataAccessLayer.Abstract;

namespace WatchRead.BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task TAddAsync(T entity)
        {
            await _genericDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(T entity)
        {
            await _genericDal.DeleteAsync(entity);
        }

        public async Task<IEnumerable<T>> TGetAllAsync()
        {
            return await _genericDal.GetAllAsync();
        }

        public async Task<T> TGetByIdAsync(int id)
        {
            return await _genericDal.GetByIdAsync(id);
        }

        public async Task TUpdateAsync(T entity)
        {
            await _genericDal.UpdateAsync(entity);
        }
    }
}
