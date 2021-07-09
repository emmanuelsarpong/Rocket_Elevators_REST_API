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
    public class batteriesController : ControllerBase
    {
        private readonly AllContext _context;

        public batteriesController(AllContext context)
        {
            _context = context;
        }

        // GET: api/batteries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<batteriesItem>>> Getbatteries()
        {
            return await _context.batteries.ToListAsync();
        }

        // GET: api/batteries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<batteriesItem>> GetbatteriesItem(long id)
        {
            var batteriesItem = await _context.batteries.FindAsync(id);

            if (batteriesItem == null)
            {
                return NotFound();
            }

            return batteriesItem;
        }

        // PUT: api/batteries/5

            [HttpPut("{id}/Active")]        //************Active****************
            public async Task<ActionResult<AllContext>> PutbatteriesItem([FromRoute]long id)
        {
            var batteriesItem = await this._context.batteries.FindAsync(id);
            if (batteriesItem == null)
            {
                return NotFound();
            }
            else
            {
                batteriesItem.Status = "Active";
            }
            this._context.batteries.Update(batteriesItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the batteries " + batteriesItem.id + 
             " Was change to " + batteriesItem.Status);
        }

        [HttpPut("{id}/Inactive")]                 //************Inactive****************
            public async Task<ActionResult<AllContext>> PutbatteriesItemi([FromRoute]long id)
        {
            var batteriesItem = await this._context.batteries.FindAsync(id);
            if (batteriesItem == null)
            {
                return NotFound();
            }
            else
            {
                batteriesItem.Status = "Inactive";
            }
            this._context.batteries.Update(batteriesItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the batteries " + batteriesItem.id + 
             " Was change to " + batteriesItem.Status);
        }

            [HttpPut("{id}/Intervention")]          //************Intervention****************
            public async Task<ActionResult<AllContext>> PutbatteriesItemin([FromRoute]long id)
        {
            var batteriesItem = await this._context.batteries.FindAsync(id);
            if (batteriesItem == null)
            {
                return NotFound();
            }
            else
            {
                batteriesItem.Status = "Intervention";
            }
            this._context.batteries.Update(batteriesItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the batteries " + batteriesItem.id + 
             " Was change to " + batteriesItem.Status);
        }
        // public async Task<IActionResult> PutbatteriesItem(long id, batteriesItem batteriesItem)
        // {
        //     if (id != batteriesItem.id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(batteriesItem).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!batteriesItemExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // POST: api/batteries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<batteriesItem>> PostbatteriesItem(batteriesItem batteriesItem)
        {
            _context.batteries.Add(batteriesItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetbatteriesItem", new { id = batteriesItem.id }, batteriesItem);
        }

        // DELETE: api/batteries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletebatteriesItem(long id)
        {
            var batteriesItem = await _context.batteries.FindAsync(id);
            if (batteriesItem == null)
            {
                return NotFound();
            }

            _context.batteries.Remove(batteriesItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool batteriesItemExists(long id)
        {
            return _context.batteries.Any(e => e.id == id);
        }
    }
}
