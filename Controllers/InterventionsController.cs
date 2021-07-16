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
    public class InterventionsController : ControllerBase
    {
        private readonly AllContext _context;

        public InterventionsController(AllContext context)
        {
            _context = context;
        }

        // GET: api/interventions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InterventionsItem>>> Getinterventions()
        {
            System.Diagnostics.Debug.WriteLine("Hello this is a test");
            return await _context.interventions.ToListAsync();
            
        }

        //GET: Returns all fields of all Service 
        //Request records that do not have a start date and are in "Pending" status.
        //https://localhost:5001/api/intervention/PendingList
         [HttpGet("PendingList")]
        public IEnumerable<InterventionsItem> GetInterventions() {
            IQueryable<InterventionsItem> Interventions =
            from le in _context.interventions
            where le.Start_Date == null && le.Status == "Pending"
            select le;
            

            return Interventions.ToList();
        }

        // GET: api/interventions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InterventionsItem>> GetinterventionsItem(long id)
        {
            var interventionsItem = await _context.interventions.FindAsync(id);

            if (interventionsItem == null)
            {
                return NotFound();
            }

            return interventionsItem;
        }

        // PUT: api/interventions/5
        [HttpPut("{id}/inprogress")]        //************Active****************
        public async Task<ActionResult<AllContext>> PutinterventionsItem([FromRoute]long id)
        {
            var interventionsItem = await this._context.interventions.FindAsync(id);
            if (interventionsItem.Status == "Pending")
            {
                interventionsItem.Status = "inprogress";
                interventionsItem.Start_Date = DateTime.Now;
            }
            else
            {
                return NotFound();
            }
            this._context.interventions.Update(interventionsItem);
            await this._context.SaveChangesAsync();
            return Content(interventionsItem.Start_Date + "of the interventions " + interventionsItem.id + 
             " Was change to " + interventionsItem.Status);
        }

        // PUT: api/interventions/5
        [HttpPut("{id}/complete")]        //************Active****************
        public async Task<ActionResult<AllContext>> ChangeToComplete([FromRoute]long id)
        {
            var interventionsItem = await this._context.interventions.FindAsync(id);
            if (interventionsItem.Status == "inprogress")
            {
                interventionsItem.Status = "complete";
                interventionsItem.End_Date = DateTime.Now;
            }
            else
            {
                return NotFound();
            }
            this._context.interventions.Update(interventionsItem);
            await this._context.SaveChangesAsync();
            return Content(interventionsItem.End_Date + "of the interventions " + interventionsItem.id + 
             " Was change to " + interventionsItem.Status);
        }


        private bool interventionsItemExists(long id)
        {
            return _context.interventions.Any(e => e.id == id);
        }
    }
}
