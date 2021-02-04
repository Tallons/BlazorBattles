using System.Threading.Tasks;
using BlazorBattles.Server.Data;
using BlazorBattles.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBattles.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRepo.Register(
                new User {
                    Username = request.Username,
                    Email = request.Email,
                    Food = request.Food,
                    DateOfBirth = request.DateOfBirth,
                    IsConfirmed = request.IsConfirmed
                }, request.Password
            );
            
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(Response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var response = await _authRepo.Login(request.Email, request.Password);
            if (!response.Success)
            {
                return BadRequest(request);
            }

            return Ok(response);
        }
    }
}