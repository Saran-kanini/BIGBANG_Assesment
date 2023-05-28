using System.Collections.Generic;
using System.Threading.Tasks;
using BIGBANG_Assesment.Models;
using BIGBANG_Assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BIGBANG_Assesment.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/Customers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            return Ok(customers);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public IActionResult PutCustomer(int id, Customer customer)
        {
            customer.UserId = id;
            _customerRepository.UpdateCustomer(customer);
            return NoContent();
        }

        // POST: api/Customers
        [HttpPost]
        public ActionResult<Customer> PostCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.UserId }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
                return NotFound();

            _customerRepository.DeleteCustomer(customer);
            return NoContent();
        }
    }
}
