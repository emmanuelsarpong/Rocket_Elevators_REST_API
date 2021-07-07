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
    public class columnsController : ControllerBase
    {
        private readonly columnsContext _context;

        public columnsController(columnsContext context)
        {
            _context = context;
        }

        // GET: api/columns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<columnsItem>>> Getcolumns()
        {
            return await _context.columns.ToListAsync();
        }

        // GET: api/columns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<columnsItem>> GetcolumnsItem(long id)
        {
            var columnsItem = await _context.columns.FindAsync(id);

            if (columnsItem == null)
            {
                return NotFound();
            }

            return columnsItem;
        }

        // PUT: api/columns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutcolumnsItem(long id, columnsItem columnsItem)
        {
            if (id != columnsItem.id)
            {
                return BadRequest();
            }

            _context.Entry(columnsItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!columnsItemExists(id))
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

        // POST: api/columns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<columnsItem>> PostcolumnsItem(columnsItem columnsItem)
        {
            _context.columns.Add(columnsItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetcolumnsItem", new { id = columnsItem.id }, columnsItem);
        }

        // DELETE: api/columns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletecolumnsItem(long id)
        {
            var columnsItem = await _context.columns.FindAsync(id);
            if (columnsItem == null)
            {
                return NotFound();
            }

            _context.columns.Remove(columnsItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool columnsItemExists(long id)
        {
            return _context.columns.Any(e => e.id == id);
        }
    }
}
