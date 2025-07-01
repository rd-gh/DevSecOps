using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using S1A.Services;
using S1A.Models;

namespace S1A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRole(int id)
        {
            var role = await _userService.GetUserRoleAsync(id);
            return Ok(new RoleResponse { UserId = id, Role = role });
        }
    }
}