using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using Microsoft.AspNetCore.Authorization;

namespace ELibrary.Controllers
{
    [Authorize(Roles = "Admin,Teacher")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaiGiangController : ControllerBase
    {
        private readonly DataContext _context;
        public BaiGiangController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<BaiGiang>>> GetBaiGiang()
        {
            return Ok(await _context.BaiGiang.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<BaiGiang>>> PostBaiGiang(BaiGiang BaiGiang)
        {
            _context.BaiGiang.Add(BaiGiang);
            await _context.SaveChangesAsync();
            return Ok(await _context.BaiGiang.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<BaiGiang>>> PutBaiGiang(BaiGiang BaiGiang)
        {
            var dbBaiGiang = await _context.BaiGiang.FindAsync(BaiGiang.ID_BaiGiang);
            if (dbBaiGiang == null)
                return BadRequest("Không Tồn Tại");
            dbBaiGiang.NAME_BaiGiang = BaiGiang.NAME_BaiGiang;
            dbBaiGiang.DESCRIPTION_BaiGiang = BaiGiang.DESCRIPTION_BaiGiang;

            await _context.SaveChangesAsync();
            return Ok(await _context.BaiGiang.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<BaiGiang>>> DeleteBaiGiang(int id)
        {
            var dbBaiGiang = await _context.BaiGiang.FindAsync(id);
            if (dbBaiGiang == null)
                return BadRequest("Không tồn tại");
            _context.BaiGiang.Remove(dbBaiGiang);
            await _context.SaveChangesAsync();

            return Ok(await _context.DanhSachMonGiangDay.ToListAsync());
        }
    }
}
