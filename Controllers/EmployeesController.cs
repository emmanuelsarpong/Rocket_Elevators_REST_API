using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Rocket_Employees_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AllContext _context;
        public EmployeesController(AllContext context)
        {
            _context = context;
        }
                      
        // GET: api/employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeesItem>>>  GetEmployee()
        {
            return await _context.employees.ToListAsync();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeesItem>> GetEmployeesItem(long id)
        {
            var EmployeesItem = await _context.employees.FindAsync(id);

            if (EmployeesItem == null)
            {
                return NotFound();
            }

            return EmployeesItem;
        }

        // To get an intervention by email                             
        // GET: api/employee/{email}  
        [HttpGet("{employee_email}")]
        public ActionResult<List<EmployeesItem>> FindEmployee_Email(string employee_email)
        {
            var email = _context.employees.Where(t => t.email == employee_email).ToList();

            if (email.Count == 0)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
