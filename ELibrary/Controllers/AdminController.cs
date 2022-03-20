using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using Microsoft.AspNetCore.Authorization;

namespace ELibrary.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly DataContext _context;

        public AdminController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Admin>>> GetAdmin()
        {
            return Ok(await _context.Admin.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Admin>>> PostThongBao(Admin Admin)
        {
            _context.Admin.Add(Admin);
            await _context.SaveChangesAsync();
            return Ok(await _context.Admin.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Admin>>> UpdateAdmin(Admin Admin)
        {
            var dbAdmin = await _context.Admin.FindAsync(Admin.ID_Admin);
            if (dbAdmin == null)
                return BadRequest("Không Tồn Tại");
            dbAdmin.NAME_Admin = Admin.NAME_Admin;
            await _context.SaveChangesAsync();
            return Ok(await _context.Admin.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Admin>>> DeleteAdmin(int id)
        {
            var dbAdmin = await _context.Admin.FindAsync(id);
            if (dbAdmin == null)
                return BadRequest("Không tồn tại");
            _context.Admin.Remove(dbAdmin);
            await _context.SaveChangesAsync();
            return Ok(await _context.Admin.ToListAsync());
        }
    }
}
