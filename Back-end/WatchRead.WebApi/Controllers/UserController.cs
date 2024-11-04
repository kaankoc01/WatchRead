using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DtoLayer.DTOs.UserDto;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultUserDto>>> GetAll()
        {
            var users = await _userService.TGetAllAsync();
            var userDtos = _mapper.Map<IEnumerable<ResultUserDto>>(users);
            return Ok(userDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResultUserDto>> GetById(int id)
        {
            var user = await _userService.TGetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<ResultUserDto>(user);
            return Ok(userDto);
        }

        [HttpPost]
        public async Task<ActionResult<ResultUserDto>> Create(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);
            await _userService.TAddAsync(user);
            var userDto = _mapper.Map<ResultUserDto>(user);
            return CreatedAtAction(nameof(GetById), new { id = user.UserId }, userDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultUserDto>> Update(int id, UpdateUserDto updateUserDto)
        {
            if (id != updateUserDto.UserId)
            {
                return BadRequest();
            }

            var user = _mapper.Map<User>(updateUserDto);
            await _userService.TUpdateAsync(user);
            var userDto = _mapper.Map<ResultUserDto>(user);
            return Ok(userDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userService.TGetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _userService.TDeleteAsync(user);
            return NoContent();
        }
    }
}
