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
    public class CategoryManager :GenericManager<Category>, ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) :base(categoryDal) 
        {
            _categoryDal = categoryDal;
        }
        // kategoriye özel metodlar eklenecek yer.
    }
}
