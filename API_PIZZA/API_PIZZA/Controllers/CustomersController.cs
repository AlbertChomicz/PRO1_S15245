using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API_PIZZA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PIZZA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private _2019SBDContext _context;

        public CustomersController(_2019SBDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getCustomers(String order = "name")
        {   
            return Ok(_context.AchCustomer.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult getCustomers(int id)
        {
            var customer = _context.AchCustomer.FirstOrDefault(e => e.IdCustomer == id);

            if (customer == null)
            { return NotFound(); }

            return Ok(customer);


        }

        [HttpPost]
        public IActionResult Create(AchCustomer newCustomer)
        {

            var newId = _context.AchCustomer.OrderByDescending(i => i.IdCustomer).FirstOrDefault().IdCustomer + 1;
            newCustomer.IdCustomer = newId;


            _context.AchCustomer.Add(newCustomer);
            _context.SaveChanges();
            return StatusCode(201, newCustomer) ;
        }

        [HttpPut("{id:int}")]
        public IActionResult Update (int id, AchCustomer updatedCustomer)
        {
        
            if (_context.AchCustomer.Count(e => e.IdCustomer == id) ==  0){
                return NotFound();
            }

            _context.AchCustomer.Attach(updatedCustomer);
            _context.Entry(updatedCustomer).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updatedCustomer);

        }   

        [HttpDelete("{item_id:int}")]
            public IActionResult Delete (int item_id)
        {

            var customer = _context.AchCustomer.FirstOrDefault(e => e.IdCustomer == item_id);

            if (customer == null)
            {
                return NotFound();
            }

            _context.AchCustomer.Remove(customer);
            _context.SaveChanges();
            return Ok(customer);
        }
    }

}