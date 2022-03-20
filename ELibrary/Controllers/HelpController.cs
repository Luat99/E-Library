using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using Microsoft.AspNetCore.Authorization;

namespace ELibrary.Controllers
{
    [Authorize(Roles = "Admin,Teacher")]
    [Route("api/[controller]")]
    [ApiController]
    public class HelpController : ControllerBase
    {
        private readonly DataContext _context;
        public HelpController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Help>>> GetHelp()
        {
            return Ok(await _context.Help.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Help>>> PostHelp(Help Help)
        {
            _context.Help.Add(Help);
            await _context.SaveChangesAsync();
            return Ok(await _context.Help.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Help>>> PutHelp(Help Help)
        {
            var dbHelp = await _context.Help.FindAsync(Help.ID_Help);
            if (dbHelp == null)
                return BadRequest("Không Tồn Tại");
            dbHelp.NAME_Help = Help.NAME_Help;
            dbHelp.DESCRIPTION_Help = Help.DESCRIPTION_Help;

            await _context.SaveChangesAsync();
            return Ok(await _context.Help.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Help>>> DeleteHelp(int id)
        {
            var dbHelp = await _context.Help.FindAsync(id);
            if (dbHelp == null)
                return BadRequest("Không tồn tại");
            _context.Help.Remove(dbHelp);
            await _context.SaveChangesAsync();

            return Ok(await _context.Help.ToListAsync());
        }
    }
}
