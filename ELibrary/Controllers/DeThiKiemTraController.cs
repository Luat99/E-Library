using ELibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ELibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "ADMIN,Teacher")]

    public class DeThiKiemTraController : ControllerBase
    {
        private readonly DataContext _context;
        public DeThiKiemTraController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<DeThiKiemTra>>> GetDeThiKiemTra()
        {
            return Ok(await _context.DeThiKiemTra.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<DeThiKiemTra>>> PostDeThiKiemTra(DeThiKiemTra DeThiKiemTra)
        {
            _context.DeThiKiemTra.Add(DeThiKiemTra);
            await _context.SaveChangesAsync();
            return Ok(await _context.DeThiKiemTra.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<DeThiKiemTra>>> PutDeThiKiemTra(DeThiKiemTra DeThiKiemTra)
        {
            var dbDeThiKiemTra = await _context.DeThiKiemTra.FindAsync(DeThiKiemTra.ID_DeThiKiemTra);
            if (dbDeThiKiemTra == null)
                return BadRequest("Không Tồn Tại");
            dbDeThiKiemTra.NAME_DeThiKiemTra = DeThiKiemTra.NAME_DeThiKiemTra;
            dbDeThiKiemTra.DESCRIPTION_DeThiKiemTra = DeThiKiemTra.DESCRIPTION_DeThiKiemTra;

            await _context.SaveChangesAsync();
            return Ok(await _context.DeThiKiemTra.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<DeThiKiemTra>>> DeleteDeThiKiemTra(int id)
        {
            var dbDeThiKiemTra = await _context.DeThiKiemTra.FindAsync(id);
            if (dbDeThiKiemTra == null)
                return BadRequest("Không tồn tại");
            _context.DeThiKiemTra.Remove(dbDeThiKiemTra);
            await _context.SaveChangesAsync();

            return Ok(await _context.DeThiKiemTra.ToListAsync());
        }
    }
}
