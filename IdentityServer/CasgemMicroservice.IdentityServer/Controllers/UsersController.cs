using CasgemMicroservice.IdentityServer.Dtos;
using CasgemMicroservice.IdentityServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using System.Linq;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace CasgemMicroservice.IdentityServer.Controllers
{
    [Authorize(LocalApi.PolicyName)] //eklendi - 1
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto signUpDto)
        {
            var user = new ApplicationUser()
            {
                UserName = signUpDto.Username,
                Email = signUpDto.Email,
                City = signUpDto.City,
                NameSurname = signUpDto.NameSurname
            };
            await _userManager.CreateAsync(user,signUpDto.Password);
            return NoContent();
        }
        [HttpGet] //Postmen de gelen token ı çözüyor
        public async Task<IActionResult> GetUser()
        {
            var values = User.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Sub);
            var user = await _userManager.FindByIdAsync(values.Value);
            return Ok(new
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                City = user.City,

            });
        }
    }
}
