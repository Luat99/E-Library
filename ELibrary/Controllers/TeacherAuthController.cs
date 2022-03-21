using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;

namespace ELibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherAuthController : ControllerBase
    {
        public static TeacherRegister Teacher = new TeacherRegister();
        private readonly IConfiguration _configuration;

        public TeacherAuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult<TeacherRegister>> Register(TeacherDTO request)
        {
            CreatePassHash_Teacher(request.PASS_Teacher, out byte[] PassHash_Teacher, out byte[] PassSalt_Teacher);

            Teacher.USER_Teacher = request.USER_Teacher;
            Teacher.PassHash_Teacher = PassHash_Teacher;
            Teacher.PassSalt_Teacher = PassSalt_Teacher;

            return Ok(Teacher);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(TeacherDTO request)
        {
            if (Teacher.USER_Teacher != request.USER_Teacher)
            {
                return BadRequest("User không tồn tại.");
            }

            if (!VerifyPassHash_Teacher(request.PASS_Teacher, Teacher.PassHash_Teacher, Teacher.PassSalt_Teacher))
            {
                return BadRequest("Sai mật khẩu");
            }

            string token = CreateToken(Teacher);
            return Ok(token);
        }

        private string CreateToken(TeacherRegister Teacher)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Teacher.USER_Teacher),
                new Claim(ClaimTypes.Role, "Teacher")
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

        private void CreatePassHash_Teacher(string PASS_Teacher, out byte[] PassHash_Teacher, out byte[] PassSalt_Teacher)
        {
            using (var hmac = new HMACSHA512())
            {
                PassSalt_Teacher = hmac.Key;
                PassHash_Teacher = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PASS_Teacher));
            }
        }

        private bool VerifyPassHash_Teacher(string PASS_Teacher, byte[] PassHash_Teacher, byte[] PassSalt_Teacher)
        {
            using (var hmac = new HMACSHA512(PassSalt_Teacher))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PASS_Teacher));
                return computedHash.SequenceEqual(PassHash_Teacher);
            }
        }
    }
}
