using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.DtoLayer.DTOs.RoleDto;
using WatchRead.EntityLayer.Concrete;

namespace WatchRead.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultRoleDto>>> GetAll()
        {
            var roles = await _roleService.TGetAllAsync();
            var roleDtos = _mapper.Map<IEnumerable<ResultRoleDto>>(roles);
            return Ok(roleDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResultRoleDto>> GetById(int id)
        {
            var role = await _roleService.TGetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            var roleDto = _mapper.Map<ResultRoleDto>(role);
            return Ok(roleDto);
        }

        [HttpPost]
        public async Task<ActionResult<ResultRoleDto>> Create(CreateRoleDto createRoleDto)
        {
            var role = _mapper.Map<Role>(createRoleDto);
            await _roleService.TAddAsync(role);
            var roleDto = _mapper.Map<ResultRoleDto>(role);
            return CreatedAtAction(nameof(GetById), new { id = role.RoleId }, roleDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultRoleDto>> Update(int id, UpdateRoleDto updateRoleDto)
        {
            if (id != updateRoleDto.RoleId)
            {
                return BadRequest();
            }

            var role = _mapper.Map<Role>(updateRoleDto);
            await _roleService.TUpdateAsync(role);
            var roleDto = _mapper.Map<ResultRoleDto>(role);
            return Ok(roleDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var role = await _roleService.TGetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            await _roleService.TDeleteAsync(role);
            return NoContent();
        }
    }
}
