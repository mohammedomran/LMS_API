using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;
using TestApiJWT.Services;

namespace TestApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(new { user = result, status = true, code = 200, msg = "user registered successfully" });
        }

        [HttpPost("admin/register")]
        public async Task<IActionResult> RegisterAdminAsync([FromBody] JObject data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = data["user"].ToObject<RegisterModel>();
            var type = data["type"].ToString();
            //return Ok(user);
            var result = await _authService.RegisterAdminAsync(user, type);

            /*if (!result.IsAuthenticated)
                return BadRequest(result.Message);*/

            return Ok(new { user = result, status = true, code = 200, msg = "admin registered successfully" });
        }

        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync([FromBody] TokenRequestModel model)
        {
            if (!ModelState.IsValid)
                return Ok(new { status = false, code = 400, msg = ModelState });

            var result = await _authService.GetTokenAsync(model);

            if (!result.IsAuthenticated)
                return Ok(new { status = false, code = 400, msg = result.Message });

            return Ok(new { user = result, status = true, code = 200, msg = "user logged in successfully" });
        }

        [HttpPost("addrole")]
        public async Task<IActionResult> AddRoleAsync([FromBody] AddRoleModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.AddRoleAsync(model);

            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);

            return Ok(model);
        }
    }
}