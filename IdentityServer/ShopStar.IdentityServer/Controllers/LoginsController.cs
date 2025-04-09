using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopStar.IdentityServer.Dtos;
using ShopStar.IdentityServer.Models;
using System.Threading.Tasks;

namespace ShopStar.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginsController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

     
        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginDto userLoginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(userLoginDto.UserName, userLoginDto.Password, false, false);
            if (result.Succeeded)
            {
                return Ok("login success");
            }
            else
            {
                return Ok("username or password wrong");
            }

        }
    }
}
