#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Model;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoDbContext _context;

        public TodoController(TodoDbContext context)
        {
            _context = context;
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoAppointment>>> GetToDoAppointments()
        {
            return await _context.ToDoAppointments.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoAppointment>> GetToDoAppointment(uint id)
        {
            var toDoAppointment = await _context.ToDoAppointments.FindAsync(id);

            if (toDoAppointment == null)
            {
                return NotFound();
            }

            return toDoAppointment;
        }

        // PUT: api/Todo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDoAppointment(uint id, ToDoAppointment toDoAppointment)
        {
            if (id != toDoAppointment.ToDoAppointmentId)
            {
                return BadRequest();
            }

            _context.Entry(toDoAppointment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoAppointmentExists(id))
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

        // POST: api/Todo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ToDoAppointment>> PostToDoAppointment(ToDoAppointment toDoAppointment)
        {
            _context.ToDoAppointments.Add(toDoAppointment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetToDoAppointment), new { id = toDoAppointment.ToDoAppointmentId }, toDoAppointment);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchToDoAppointment(uint id)
        {

            var appointItem = await _context.ToDoAppointments.FindAsync(id);
            if (appointItem == null)
            {
                return NotFound();
            }
            appointItem.IsConfirmed = true;
            _context.Update(appointItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoAppointment(uint id)
        {
            var toDoAppointment = await _context.ToDoAppointments.FindAsync(id);
            if (toDoAppointment == null)
            {
                return NotFound();
            }

            _context.ToDoAppointments.Remove(toDoAppointment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToDoAppointmentExists(uint id)
        {
            return _context.ToDoAppointments.Any(e => e.ToDoAppointmentId == id);
        }
    }
}
