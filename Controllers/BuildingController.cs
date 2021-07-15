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
    public class BuildingController : ControllerBase
    {
        private readonly AllContext _context;

        public BuildingController(AllContext context)
        {
            _context = context;
        }

        // GET: api/Building
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuildingItem>>> Getbuilding()
        {
            return await _context.buildings.ToListAsync();
        }

        // GET: api/Building/5
        [HttpGet("intervention")]
        public IEnumerable<BuildingItem> GetBuildingsIntervention() 
        {
            IQueryable<BuildingItem> Building = from build in _context.buildings
                join batte in _context.batteries on build.id equals batte.building_id
                join colum in _context.columns on batte.id equals colum.battery_id
                join eleva in _context.elevators on colum.id equals eleva.column_id
                where batte.Status == "intervention" || colum.Status == "intervention" || eleva.Status == "intervention"
                select build;
            return Building.ToList();
        }

        private bool BuildingItemExists(long id)
        {
            return _context.buildings.Any(e => e.id == id);
        }
    }
}
