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
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> UserRegister(UserRegisterDto userRegisterDto)
        {
            var values = new ApplicationUser 
            { 
                UserName = userRegisterDto.UserName,
                Email = userRegisterDto.Email,
                Name=userRegisterDto.Name,
                Surename=userRegisterDto.Surename,
            };
            var result=await _userManager.CreateAsync(values,userRegisterDto.Password);
            if (result.Succeeded)
            {
                return Ok("user added successful");
            }
            else
            {
                return Ok("Error");
            }

        }
    }
}
