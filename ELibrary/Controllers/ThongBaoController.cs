using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;

namespace ELibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongBaoController : ControllerBase
    {
        private readonly DataContext _context;
        public ThongBaoController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<ThongBao>>> GetThongBao()
        {
            return Ok(await _context.ThongBao.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<ThongBao>>> PostThongBao(ThongBao ThongBao)
        {
            _context.ThongBao.Add(ThongBao);
            await _context.SaveChangesAsync();
            return Ok(await _context.ThongBao.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<ThongBao>>> PutThongBao(ThongBao ThongBao)
        {
            var dbThongBao = await _context.ThongBao.FindAsync(ThongBao.ID_ThongBao);
            if (dbThongBao == null)
                return BadRequest("Không Tồn Tại");
            dbThongBao.NAME_ThongBao = ThongBao.NAME_ThongBao;
            dbThongBao.DESCRIPTION_ThongBao = ThongBao.DESCRIPTION_ThongBao;
            await _context.SaveChangesAsync();
            return Ok(await _context.ThongBao.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ThongBao>>> DeleteThongBao(int id)
        {
            var dbThongBao = await _context.ThongBao.FindAsync(id);
            if (dbThongBao == null)
                return BadRequest("Không tồn tại");
            _context.ThongBao.Remove(dbThongBao);
            await _context.SaveChangesAsync();
            return Ok(await _context.ThongBao.ToListAsync());
        }
    }
}
