using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System;


namespace Rocket_Elevators_REST_API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AllContext _context;
        public EmployeeController(AllContext context)
        {
            _context = context;
        }

        // To see all the employees                          
        // GET: api/employees/all
        [HttpGet("all")]
        public IEnumerable<EmployeesItem> GetEmployee()
        {
            return _context.employees;
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