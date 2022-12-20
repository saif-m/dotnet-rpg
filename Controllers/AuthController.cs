using dotnet_rpg.Data;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Dtos.User;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _AuthRepo;

        public AuthController(IAuthRepository AuthRepo)
        {
            _AuthRepo = AuthRepo;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDto request)
        {
            var response = await _AuthRepo.Login(request.Username, request.Password);

            if (!response.Success) {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> AddUser(UserRegisterDto request)
        {
            var response = await _AuthRepo.Register(
                new User{ Username = request.Username }, request.Password
            );

            if (!response.Success) {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}