using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
namespace ELibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly DataContext _context;

        public TeacherController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Teacher>>> GetTeacher()
        {
            return Ok(await _context.Teacher.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Teacher>>> PostTeacher(Teacher Teacher)
        {
            _context.Teacher.Add(Teacher);
            await _context.SaveChangesAsync();
            return Ok(await _context.Teacher.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Teacher>>> UpdateTeacher(Teacher Teacher)
        {
            var dbTeacher = await _context.Teacher.FindAsync(Teacher.ID_Teacher);
            if (dbTeacher == null)
                return BadRequest("Không Tồn Tại");
            dbTeacher.NAME_Teacher = Teacher.NAME_Teacher;
            await _context.SaveChangesAsync();
            return Ok(await _context.Admin.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Admin>>> DeleteTeacher(int id)
        {
            var dbTeacher = await _context.Teacher.FindAsync(id);
            if (dbTeacher == null)
                return BadRequest("Không tồn tại.");
            _context.Teacher.Remove(dbTeacher);
            await _context.SaveChangesAsync();
            return Ok(await _context.Teacher.ToListAsync());
        }
    }
}
