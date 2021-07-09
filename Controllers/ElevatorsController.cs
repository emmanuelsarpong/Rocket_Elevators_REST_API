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
        private readonly AllContext _context;

        public ElevatorsController(AllContext context)
        {
            _context = context;
        }

    [HttpGet("notactive")]
        public async Task<IEnumerable<ElevatorItem>> Getelevatorsnotactive()
        {
            IQueryable<ElevatorItem> ElevatorItem = 
            from elevator in _context.elevators
            where elevator.Status != "Active"
            select elevator;

            return ElevatorItem.ToList();
        }


        // GET: api/Elevators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElevatorItem>>> Getelevators()
        {
            return await _context.elevators.ToListAsync();
        }

        // GET: api/Elevators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElevatorItem>> GetelevatorsItem(long id)
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

        [HttpPut("{id}/Active")]        //************Active****************
                public async Task<ActionResult<AllContext>> PutElevatorsItem([FromRoute]long id)
        {
            var elevatorsItem = await this._context.elevators.FindAsync(id);
            if (elevatorsItem == null)
            {
                return NotFound();
            }
            else
            {
                elevatorsItem.Status = "Active";
            }

            this._context.elevators.Update(elevatorsItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the Elevators " + elevatorsItem.id + 
             " Was change to " + elevatorsItem.Status);
        }

        [HttpPut("{id}/Inactive")]       //************Inactive****************
                public async Task<ActionResult<AllContext>> PutElevatorsItemi([FromRoute]long id)
        {
            var elevatorsItem = await this._context.elevators.FindAsync(id);
            if (elevatorsItem == null)
            {
                return NotFound();
            }
            else
            {
                elevatorsItem.Status = "Inactive";
            }

            this._context.elevators.Update(elevatorsItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the Elevators " + elevatorsItem.id + 
             " Was change to " + elevatorsItem.Status);
        }

        [HttpPut("{id}/Intervention")]    //************Intervention****************
                public async Task<ActionResult<AllContext>> PutElevatorsItemin([FromRoute]long id)
        {
            var elevatorsItem = await this._context.elevators.FindAsync(id);
            if (elevatorsItem == null)
            {
                return NotFound();
            }
            else
            {
                elevatorsItem.Status = "Intervention";
            }

            this._context.elevators.Update(elevatorsItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the Elevators " + elevatorsItem.id + 
             " Was change to " + elevatorsItem.Status);
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
