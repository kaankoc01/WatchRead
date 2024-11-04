using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DtoLayer.DTOs.CategoryDto;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        //// GET: api/category
        //[HttpGet]
        //public async Task<ActionResult<List<ResultCategoryDto>>> GetAllCategories()
        //{
        //    var categories = await _categoryService.TGetAllAsync();
        //    var categoryDtos = _mapper.Map<List<ResultCategoryDto>>(categories);
        //    return Ok(categoryDtos);
        //}


        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultCategoryDto>>> GetCategories()
        {
            var categories = await _categoryService.TGetAllAsync();
            var categoryDtos = _mapper.Map<IEnumerable<ResultCategoryDto>>(categories);
            return Ok(categoryDtos);
        }

        // GET: api/Category/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ResultCategoryDto>> GetCategory(int id)
        {
            var category = await _categoryService.TGetByIdAsync(id);
            if (category == null)
            {
                return NotFound("Category not found.");
            }
            var categoryDto = _mapper.Map<ResultCategoryDto>(category);
            return Ok(categoryDto);
        }

        // POST: api/Category
        [HttpPost]
        public async Task<ActionResult> AddCategory([FromBody] CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            await _categoryService.TAddAsync(category);
            var createdCategoryDto = _mapper.Map<CreateCategoryDto>(category);

            return Ok();
           
        }

        // PUT: api/Category/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCategory(int id, [FromBody] UpdateCategoryDto updateCategoryDto)
        {
            if (id != updateCategoryDto.CategoryId)
            {
                return BadRequest();
            }

            var categoryToUpdate = _mapper.Map<Category>(updateCategoryDto);
            await _categoryService.TUpdateAsync(categoryToUpdate);
            return NoContent();
        }

        // DELETE: api/Category/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            var category = await _categoryService.TGetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            await _categoryService.TDeleteAsync(category);
            return NoContent();


        }
    }
}
