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
        private readonly IMapper _mapper; // Mapper'ı ekliyoruz

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper) : base(categoryDal)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }
        //public async Task<int> GetContentCountByCategoryAsync(int categoryId)
        //{
        //    // İçerik tablosunda categoryId ile eşleşen kayıtları sayar
        //    return await _contentDal.CountAsync(c => c.CategoryId == categoryId);
        //}


        //public async Task<List<ResultCategoryDto>> SearchCategoriesByNameAsync(string name)
        //{
        //    var categories = await _categoryDal.GetAllAsync(c => c.Name.Contains(name));
        //    return _mapper.Map<List<ResultCategoryDto>>(categories);
        //}
        // kategoriye özel metodlar eklenecek yer.

        public ResultCategoryDto GetCategoryDtoById(int id)
        {
            var category = _categoryDal.GetByIdAsync(id);
            return _mapper.Map<ResultCategoryDto>(category);
        }

        public void CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            _categoryDal.AddAsync(category);
        }

    }
}
