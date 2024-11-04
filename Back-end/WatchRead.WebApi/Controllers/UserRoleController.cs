using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DtoLayer.DTOs.UserRoleDto;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService _userRoleService;
        private readonly IMapper _mapper;

        public UserRoleController(IUserRoleService userRoleService, IMapper mapper)
        {
            _userRoleService = userRoleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultUserRoleDto>>> GetAll()
        {
            var userRoles = await _userRoleService.TGetAllAsync();
            var userRoleDtos = _mapper.Map<IEnumerable<ResultUserRoleDto>>(userRoles);
            return Ok(userRoleDtos);
        }

        [HttpGet("{userId}/{roleId}")]
        public async Task<ActionResult<ResultUserRoleDto>> GetById(int userId, int roleId)
        {
            var userRole = await _userRoleService.TGetByUserIdAndRoleIdAsync(userId, roleId);
            if (userRole == null)
            {
                return NotFound();
            }
            var userRoleDto = _mapper.Map<ResultUserRoleDto>(userRole);
            return Ok(userRoleDto);
        }

        [HttpPost]
        public async Task<ActionResult<ResultUserRoleDto>> Create(CreateUserRoleDto createUserRoleDto)
        {
            var userRole = _mapper.Map<UserRole>(createUserRoleDto);
            await _userRoleService.TAddAsync(userRole);
            var userRoleDto = _mapper.Map<ResultUserRoleDto>(userRole);
            return CreatedAtAction(nameof(GetById), new { userId = userRole.UserId, roleId = userRole.RoleId }, userRoleDto);

        }



        [HttpPut("{userId}/{roleId}")]
        public async Task<ActionResult<ResultUserRoleDto>> Update(int userId, int roleId, UpdateUserRoleDto updateUserRoleDto)
        {
            var userRole = await _userRoleService.TGetByUserIdAndRoleIdAsync(userId, roleId);
            if (userRole == null)
            {
                return NotFound();
            }

            // UserRole'ün UserId ve RoleId'sini güncelleyin
            userRole.UserId = updateUserRoleDto.UserId;
            userRole.RoleId = updateUserRoleDto.RoleId;

            await _userRoleService.TUpdateAsync(userRole);
            var userRoleDto = _mapper.Map<ResultUserRoleDto>(userRole);
            return Ok(userRoleDto);
        }



        [HttpDelete("{userId}/{roleId}")]
        public async Task<IActionResult> Delete(int userId, int roleId)
        {
            var userRole = await _userRoleService.TGetByUserIdAndRoleIdAsync(userId, roleId);
            if (userRole == null)
            {
                return NotFound();
            }

            await _userRoleService.TDeleteAsync(userRole);
            return NoContent();
        }
    }
}
