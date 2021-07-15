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
    public class interventionsController : ControllerBase
    {
        private readonly AllContext _context;

        public interventionsController(AllContext context)
        {
            _context = context;
        }

        // GET: api/interventions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<interventionsItem>>> Getinterventions()
        {
            return await _context.interventions.ToListAsync();
        }

        //GET: Returns all fields of all Service 
        //Request records that do not have a start date and are in "Pending" status.
        //https://localhost:5001/api/intervention/PendingList
         [HttpGet("PendingList")]
        public IEnumerable<interventionsItem> GetInterventions() {
            IQueryable<interventionsItem> Interventions =
            from le in _context.interventions
            where le.Start_Date == null && le.Status == "Pending"
            select le;

            return Interventions.ToList();
        }

        // GET: api/interventions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<interventionsItem>> GetinterventionsItem(long id)
        {
            var interventionsItem = await _context.interventions.FindAsync(id);

            if (interventionsItem == null)
            {
                return NotFound();
            }

            return interventionsItem;
        }

        // PUT: api/interventions/5

            [HttpPut("{id}/Active")]        //************Active****************
            public async Task<ActionResult<AllContext>> PutinterventionsItem([FromRoute]long id)
        {
            var interventionsItem = await this._context.interventions.FindAsync(id);
            if (interventionsItem == null)
            {
                return NotFound();
            }
            else
            {
                interventionsItem.Status = "Active";
            }
            this._context.interventions.Update(interventionsItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the interventions " + interventionsItem.id + 
             " Was change to " + interventionsItem.Status);
        }

        [HttpPut("{id}/Inactive")]                 //************Inactive****************
            public async Task<ActionResult<AllContext>> PutinterventionsItemi([FromRoute]long id)
        {
            var interventionsItem = await this._context.interventions.FindAsync(id);
            if (interventionsItem == null)
            {
                return NotFound();
            }
            else
            {
                interventionsItem.Status = "Inactive";
            }
            this._context.interventions.Update(interventionsItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the interventions " + interventionsItem.id + 
             " Was change to " + interventionsItem.Status);
        }

            [HttpPut("{id}/Intervention")]          //************Intervention****************
            public async Task<ActionResult<AllContext>> PutinterventionsItemin([FromRoute]long id)
        {
            var interventionsItem = await this._context.interventions.FindAsync(id);
            if (interventionsItem == null)
            {
                return NotFound();
            }
            else
            {
                interventionsItem.Status = "Intervention";
            }
            this._context.interventions.Update(interventionsItem);
            await this._context.SaveChangesAsync();
            return Content(" Status of the interventions " + interventionsItem.id + 
             " Was change to " + interventionsItem.Status);
        }
      
        [HttpPost]
        public async Task<ActionResult<interventionsItem>> PostinterventionsItem(interventionsItem interventionsItem)
        {
            _context.interventions.Add(interventionsItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetinterventionsItem", new { id = interventionsItem.id }, interventionsItem);
        }

        // DELETE: api/interventions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteinterventionsItem(long id)
        {
            var interventionsItem = await _context.interventions.FindAsync(id);
            if (interventionsItem == null)
            {
                return NotFound();
            }

            _context.interventions.Remove(interventionsItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool interventionsItemExists(long id)
        {
            return _context.interventions.Any(e => e.id == id);
        }
    }
}
