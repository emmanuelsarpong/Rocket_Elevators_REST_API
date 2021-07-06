using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Rocket_Elevators_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorsController : ControllerBase
    {
        private readonly ElevatorContext _context;

        public ElevatorsController(ElevatorContext context)
        {
            _context = context;
        }

        // GET: api/Elevators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElevatorItem>>> Getelevators()
        {
            return await _context.elevators.ToListAsync();
        }

        // GET: api/Elevators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElevatorItem>> GetElevatorItem(long id)
        {
            var elevatorItem = await _context.elevators.FindAsync(id);

            if (elevatorItem == null)
            {
                return NotFound();
            }

            return elevatorItem;
        }

        // PUT: api/Elevators/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElevatorItem(long id, ElevatorItem elevatorItem)
        {
            if (id != elevatorItem.id)
            {
                return BadRequest();
            }

            _context.Entry(elevatorItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevatorItemExists(id))
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

        // POST: api/Elevators
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ElevatorItem>> PostElevatorItem(ElevatorItem elevatorItem)
        {
            _context.elevators.Add(elevatorItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElevatorItem", new { id = elevatorItem.id }, elevatorItem);
        }

        // DELETE: api/Elevators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElevatorItem(long id)
        {
            var elevatorItem = await _context.elevators.FindAsync(id);
            if (elevatorItem == null)
            {
                return NotFound();
            }

            _context.elevators.Remove(elevatorItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElevatorItemExists(long id)
        {
            return _context.elevators.Any(e => e.id == id);
        }
    }
}
