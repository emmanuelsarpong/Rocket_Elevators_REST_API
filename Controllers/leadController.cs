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
    public class leadController : ControllerBase
    {
        private readonly AllContext _context;

        public leadController(AllContext context)
        {
            _context = context;
        }

        // // GET: api/lead
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<leadItem>>> GetleadItem()
        // {
        //     return await _context.leads.ToListAsync();
        // }

        // GET: api/lead/5
        [HttpGet]
        public IEnumerable<leadItem> GetleadItem(long id)
        {
            var date = System.DateTime.Now.AddDays(-30);
            IQueryable<leadItem> leads =
            from leadItem in _context.leads
            where leadItem.created_at >= date
            select leadItem;
            var customlist = _context.customers.ToList();
            var Results = leads.ToList();

            foreach (var Slead in leads) {
                var Email = Slead.Email;
                foreach (var customers in customlist){
                    if (customers.EmailOfTheCompany == Email || customers.TechManagerServiceEmail == Email) {
                       Results.RemoveAll(r => r.Email == customers.EmailOfTheCompany || r.Email == customers.TechManagerServiceEmail); 
                    }
                }
            }
            
            return Results;
        }

        // PUT: api/lead/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutleadItem(long id, leadItem leadItem)
        // {
        //     if (id != leadItem.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(leadItem).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!leadItemExists(id))
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

        // POST: api/lead
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPost]
        // public async Task<ActionResult<leadItem>> PostleadItem(leadItem leadItem)
        // {
        //     _context.leadItem.Add(leadItem);
        //     await _context.SaveChangesAsync();

        //     return CreatedAtAction("GetleadItem", new { id = leadItem.Id }, leadItem);
        // }

        // DELETE: api/lead/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteleadItem(long id)
        // {
        //     var leadItem = await _context.leadItem.FindAsync(id);
        //     if (leadItem == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.leadItem.Remove(leadItem);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        private bool leadItemExists(long id)
        {
            return _context.leads.Any(e => e.Id == id);
        }
    }
}
