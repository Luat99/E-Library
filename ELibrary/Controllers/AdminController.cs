using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models.admin;
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
        public async Task<ActionResult<List<admin>>> Getadmin()
        {
            return Ok(await _context.admin.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<admin>>> AddAdmin(admin admin)
        {
            _context.admin.Add(admin);
            await _context.SaveChangesAsync();

            return Ok(await _context.admin.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<admin>>> Updateadmin(admin request)
        {
            var dbAdmin = await _context.admin.FindAsync(request.id_admin);
            if (dbAdmin == null)
                return BadRequest("Admin not found.");

            dbAdmin.name_admin = request.name_admin;

            await _context.SaveChangesAsync();

            return Ok(await _context.admin.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<admin>>> Deleteadmin(int id)
        {
            var dbAdmin = await _context.admin.FindAsync(id);
            if (dbAdmin == null)
                return BadRequest("Admin not found.");

            _context.admin.Remove(dbAdmin);
            await _context.SaveChangesAsync();

            return Ok(await _context.admin.ToListAsync());
        }
    }
}
