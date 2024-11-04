using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DtoLayer.DTOs.ContentDto;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;

        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }

        // GET: api/content
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contents = await _contentService.TGetAllAsync();
            return Ok(contents);
        }

        // GET: api/content/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var content = await _contentService.TGetByIdAsync(id);
            if (content == null)
                return NotFound();
            return Ok(content);
        }

        // POST: api/content
        [HttpPost]
        public async Task<IActionResult> Create(CreateContentDto contentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var content = new Content
            {
                Title = contentDto.Title,
                Description = contentDto.Description,
                Type = contentDto.Type, // Type alanını ekledik
                ReleaseDate = contentDto.ReleaseDate, // ReleaseDate alanını ekledik
                CategoryId = contentDto.CategoryId, // CategoryId alanını ekledik
                Rating = contentDto.Rating // Rating alanını ekledik
            };

            await _contentService.TAddAsync(content);
            return CreatedAtAction(nameof(GetById), new { id = content.ContentId }, content);
        }

        // PUT: api/content/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateContentDto contentDto)
        {
            if (id != contentDto.ContentId)
                return BadRequest();

            var contentToUpdate = await _contentService.TGetByIdAsync(id);
            if (contentToUpdate == null)
                return NotFound();

            contentToUpdate.Title = contentDto.Title;
            contentToUpdate.Description = contentDto.Description;
            await _contentService.TUpdateAsync(contentToUpdate);
            return NoContent();
        }

        // DELETE: api/content/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var content = await _contentService.TGetByIdAsync(id);
            if (content == null)
                return NotFound();

            await _contentService.TDeleteAsync(content);
            return NoContent();
        }
    }
}