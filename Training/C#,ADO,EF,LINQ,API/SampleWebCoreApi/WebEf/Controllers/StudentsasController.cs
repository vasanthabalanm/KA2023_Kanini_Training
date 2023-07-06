using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEf.Services;

namespace WebEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsasController : ControllerBase
    {
        private readonly StudentDbcontxt _context;

        public StudentsasController(StudentDbcontxt context)
        {
            _context = context;
        }

        // GET: api/Studentsas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Studentsas>>> GetStudents()
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            return await _context.Students.ToListAsync();
        }

        // GET: api/Studentsas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Studentsas>> GetStudentsas(int id)
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            var studentsas = await _context.Students.FindAsync(id);

            if (studentsas == null)
            {
                return NotFound();
            }

            return studentsas;
        }

        // PUT: api/Studentsas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentsas(int id, Studentsas studentsas)
        {
            if (id != studentsas.StuID)
            {
                return BadRequest();
            }

            _context.Entry(studentsas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Studentsas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Studentsas>> PostStudentsas(Studentsas studentsas)
        {
          if (_context.Students == null)
          {
              return Problem("Entity set 'StudentDbcontxt.Students'  is null.");
          }
            _context.Students.Add(studentsas);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StudentsasExists(studentsas.StuID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStudentsas", new { id = studentsas.StuID }, studentsas);
        }

        // DELETE: api/Studentsas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentsas(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }
            var studentsas = await _context.Students.FindAsync(id);
            if (studentsas == null)
            {
                return NotFound();
            }

            _context.Students.Remove(studentsas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentsasExists(int id)
        {
            return (_context.Students?.Any(e => e.StuID == id)).GetValueOrDefault();
        }
    }
}
