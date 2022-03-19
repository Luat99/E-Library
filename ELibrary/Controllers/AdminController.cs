using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
namespace ELibrary.Controllers
{
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
        public async Task<ActionResult<List<Admin>>> UpdateAdmin(Admin request)
        {
            var dbAdmin = await _context.Admin.FindAsync(request.ID_Admin);
            if (dbAdmin == null)
                return BadRequest("Không Tồn Tại");
            dbAdmin.NAME_Admin = request.NAME_Admin;
            await _context.SaveChangesAsync();
            return Ok(await _context.Admin.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Admin>>> DeleteAdmin(int id)
        {
            var dbAdmin = await _context.Admin.FindAsync(id);
            if (dbAdmin == null)
                return BadRequest("Admin not found.");
            _context.Admin.Remove(dbAdmin);
            await _context.SaveChangesAsync();
            return Ok(await _context.Admin.ToListAsync());
        }
    }
}
