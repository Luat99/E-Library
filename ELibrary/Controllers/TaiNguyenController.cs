using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using Microsoft.AspNetCore.Authorization;

namespace ELibrary.Controllers
{
    [Authorize(Roles = "Admin,Teacher")]
    [Route("api/[controller]")]
    [ApiController]
    public class TaiNguyenController : ControllerBase
    {
        private readonly DataContext _context;
        public TaiNguyenController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<TaiNguyen>>> GetTaiNguyen()
        {
            return Ok(await _context.TaiNguyen.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<TaiNguyen>>> PostTaiNguyen(TaiNguyen TaiNguyen)
        {
            _context.TaiNguyen.Add(TaiNguyen);
            await _context.SaveChangesAsync();
            return Ok(await _context.TaiNguyen.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<TaiNguyen>>> PutThongBao(TaiNguyen TaiNguyen)
        {
            var dbTaiNguyen = await _context.TaiNguyen.FindAsync(TaiNguyen.ID_TaiNguyen);
            if (dbTaiNguyen == null)
                return BadRequest("Không Tồn Tại");
            dbTaiNguyen.NAME_TaiNguyen = TaiNguyen.NAME_TaiNguyen;
            dbTaiNguyen.DESCRIPTION_TaiNguyen = TaiNguyen.DESCRIPTION_TaiNguyen;

            await _context.SaveChangesAsync();
            return Ok(await _context.TaiNguyen.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<ThongBao>>> DeleteTaiNguyen(int id)
        {
            var dbTaiNguyen = await _context.TaiNguyen.FindAsync(id);
            if (dbTaiNguyen == null)
                return BadRequest("Không Tồn Tại");
            _context.TaiNguyen.Remove(dbTaiNguyen);
            await _context.SaveChangesAsync();

            return Ok(await _context.TaiNguyen.ToListAsync());
        }
    }
}
