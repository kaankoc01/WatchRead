using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DtoLayer.DTOs.CommentDto;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultCommentDto>>> GetAll()
        {
            var comments = await _commentService.TGetAllAsync();
            var commentDtos = _mapper.Map<IEnumerable<ResultCommentDto>>(comments);
            return Ok(commentDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResultCommentDto>> GetByIdAsync(int id)
        {
            var comment = await _commentService.TGetByIdAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            var commentDto = _mapper.Map<ResultCommentDto>(comment);
            return Ok(commentDto);
        }

        [HttpPost]
        public async Task<ActionResult<ResultCommentDto>> CreateAsync(CreateCommentDto createCommentDto)
        {
            var comment = _mapper.Map<Comment>(createCommentDto);
            await _commentService.TAddAsync(comment);
            var commentDto = _mapper.Map<ResultCommentDto>(comment);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = comment.CommentId }, commentDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultCommentDto>> UpdateAsync(int id, UpdateCommentDto updateCommentDto)
        {
            if (id != updateCommentDto.CommentId)
            {
                return BadRequest();
            }

            var comment = _mapper.Map<Comment>(updateCommentDto);
            await _commentService.TUpdateAsync(comment);
            var commentDto = _mapper.Map<ResultCommentDto>(comment);
            return Ok(commentDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var comment = await _commentService.TGetByIdAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            await _commentService.TDeleteAsync(comment);
            return NoContent();
        }
    }
}
