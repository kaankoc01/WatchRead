using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DataAccessLayer.Abstract;
using WatchRead.EntityLayer.Concrete;
using WatchRead.DtoLayer.DTOs.CategoryDto;
using WatchRead.DataAccessLayer.EntityFramework;

namespace WatchRead.BusinessLayer.Concrete
{
    public class CategoryManager :GenericManager<Category>, ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper; 

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper) : base(categoryDal)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }
    }
}
