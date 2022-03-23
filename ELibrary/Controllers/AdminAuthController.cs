using ELibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
namespace ELibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAuthController : ControllerBase
    {
        public static AdminRegister Admin = new AdminRegister();
        private readonly IConfiguration _configuration;

        public AdminAuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AdminRegister>> Register(AdminDTO request)
        {
            CreatePasswordHash(request.PASS_Admin, out byte[] PassHash_Admin, out byte[] PassSalt_Admin);

            Admin.USER_Admin = request.USER_Admin;
            Admin.PassHash_Admin = PassHash_Admin;
            Admin.PassSalt_Admin = PassSalt_Admin;
            return Ok(Admin);
        }

        [HttpPost("login")]
        public async Task<ActionResult<AdminDTO>> Login(AdminDTO request)
        {
            if (Admin.USER_Admin != request.USER_Admin)
            {
                return BadRequest("User không tồn tại");
            }

            if (!VerifyPasswordHash(request.PASS_Admin, Admin.PassHash_Admin, Admin.PassSalt_Admin))
            {
                return BadRequest("Sai mật khẩu");
            }

            string token = CreateToken(Admin);
            return Ok(token);
        }

        private string CreateToken(AdminRegister Admin)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Admin.USER_Admin),
                new Claim(ClaimTypes.Role, "ADMIN")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        private void CreatePasswordHash(string PASS_Admin, out byte[] PassHash_Admin, out byte[] PassSalt_Admin)
        {
            using (var hmac = new HMACSHA512())
            {
                PassSalt_Admin = hmac.Key;
                PassHash_Admin = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PASS_Admin));
            }
        }

        private bool VerifyPasswordHash(string PASS_Admin, byte[] PassHash_Admin, byte[] PassSalt_Admin)
        {
            using (var hmac = new HMACSHA512(PassSalt_Admin))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PASS_Admin));
                return computedHash.SequenceEqual(PassHash_Admin);
            }
        }
    }
}
