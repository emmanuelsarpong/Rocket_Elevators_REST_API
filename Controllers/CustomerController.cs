using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using RocketElevatorApi.Models;

namespace RocketElevatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AllContext _context;

        public CustomerController(AllContext context)
        {
            _context = context;

        }

        // To see all customer                                          https://localhost:5001/api/customer
        // GET: api/customer/all           
        [HttpGet("all")]
        public IEnumerable<CustomersItem> GetCustomers()
        {
            IQueryable<CustomersItem> Customers =
            from leaad in _context.customers

            select leaad;

            return Customers.ToList();

        }
        
    }
}