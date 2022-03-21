using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;

namespace ELibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NganHangDeThiController : ControllerBase
    {
        private readonly DataContext _context;
        public NganHangDeThiController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<NganHangDeThi>>> GetNganHangDeThi()
        {
            return Ok(await _context.NganHangDeThi.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<NganHangDeThi>>> PostNganHangDeThi(NganHangDeThi NganHangDeThi)
        {
            _context.NganHangDeThi.Add(NganHangDeThi);
            await _context.SaveChangesAsync();
            return Ok(await _context.NganHangDeThi.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<NganHangDeThi>>> PutNganHangDeThi(NganHangDeThi NganHangDeThi)
        {
            var dbNganHangDeThi = await _context.NganHangDeThi.FindAsync(NganHangDeThi.ID_NganHangDeThi);
            if (dbNganHangDeThi == null)
                return BadRequest("Không Tồn Tại");
            dbNganHangDeThi.NAME_NganHangDeThi = NganHangDeThi.NAME_NganHangDeThi;
            dbNganHangDeThi.DESCRIPTION_NganHangDeThi = NganHangDeThi.DESCRIPTION_NganHangDeThi;

            await _context.SaveChangesAsync();
            return Ok(await _context.NganHangDeThi.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<NganHangDeThi>>> DeleteNganHangDeThi(int id)
        {
            var dbNganHangDeThi = await _context.NganHangDeThi.FindAsync(id);
            if (dbNganHangDeThi == null)
                return BadRequest("Không tồn tại");
            _context.NganHangDeThi.Remove(dbNganHangDeThi);
            await _context.SaveChangesAsync();

            return Ok(await _context.NganHangDeThi.ToListAsync());
        }
    }
}
