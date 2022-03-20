using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using Microsoft.AspNetCore.Authorization;

namespace ELibrary.Controllers
{
    [Authorize(Roles = "Admin,Teacher")]
    [Route("api/[controller]")]
    [ApiController]
    public class DanhSachMonGiangDayController : ControllerBase
    {
        private readonly DataContext _context;
        public DanhSachMonGiangDayController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<DanhSachMonGiangDay>>> GetDanhSachMonGiangDay()
        {
            return Ok(await _context.DanhSachMonGiangDay.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<DanhSachMonGiangDay>>> PostDanhSachMonGiangDay(DanhSachMonGiangDay DanhSachMonGiangDay)
        {
            _context.DanhSachMonGiangDay.Add(DanhSachMonGiangDay);
            await _context.SaveChangesAsync();
            return Ok(await _context.DanhSachMonGiangDay.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<DanhSachMonGiangDay>>> PutDanhSachMonGiangDay(DanhSachMonGiangDay DanhSachMonGiangDay)
        {
            var dbDanhSachMonGiangDay = await _context.DanhSachMonGiangDay.FindAsync(DanhSachMonGiangDay.ID_DSMGiangDay);
            if (dbDanhSachMonGiangDay == null)
                return BadRequest("Không Tồn Tại");
            dbDanhSachMonGiangDay.NAME_DSMGiangDay = DanhSachMonGiangDay.NAME_DSMGiangDay;
            dbDanhSachMonGiangDay.DESCRIPTION_DSMGiangDay = DanhSachMonGiangDay.DESCRIPTION_DSMGiangDay;
            await _context.SaveChangesAsync();
            return Ok(await _context.DanhSachMonGiangDay.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<DanhSachMonGiangDay>>> DeleteDanhSachMonGiangDay(int id)
        {
            var dbDanhSachMonGiangDay = await _context.DanhSachMonGiangDay.FindAsync(id);
            if (dbDanhSachMonGiangDay == null)
                return BadRequest("Không tồn tại");
            _context.DanhSachMonGiangDay.Remove(dbDanhSachMonGiangDay);
            await _context.SaveChangesAsync();
            return Ok(await _context.DanhSachMonGiangDay.ToListAsync());
        }
    }
}
