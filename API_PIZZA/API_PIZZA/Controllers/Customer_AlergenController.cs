using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_PIZZA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PIZZA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customer_AlergenController : ControllerBase
    {



        private _2019SBDContext _context;

        public Customer_AlergenController(_2019SBDContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult getall()
        {
            return Ok(_context.AchCustomerAlergen.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult getByCustomerID(int id)
        {
            var alergens = _context.AchCustomerAlergen.Where(e => e.AchCustomerIdCustomer == id).ToList();


            if (alergens == null)
            { return NotFound(); }

            return Ok(alergens);

        }



        [HttpPost]
        public IActionResult Create(AchCustomerAlergen newItem)
        {

            var newId = _context.AchCustomerAlergen.OrderByDescending(i => i.CustomerAlergenId).FirstOrDefault().CustomerAlergenId + 1;
            newItem.CustomerAlergenId = newId;


            _context.AchCustomerAlergen.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchCustomerAlergen updated_item)
        {

            var item = _context.AchCustomerAlergen.Count(e => e.CustomerAlergenId == item_id);

            if (item == 0)
            {
                return NotFound();
            }

            _context.AchCustomerAlergen.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);

        }

        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchCustomerAlergen.FirstOrDefault(e => e.CustomerAlergenId == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchCustomerAlergen.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }





        [HttpDelete("all/{customer_id:int}")]
        public IActionResult DeleteAll(int customer_id)
        {
            var list = _context.AchCustomerAlergen.Where(e => e.AchCustomerIdCustomer == customer_id).ToList();


            if (list.Count() == 0)
            {
                return NotFound();
            }

            list.ForEach(e => _context.AchCustomerAlergen.Remove(e));
            _context.SaveChanges();
            return Ok(list);

        }


    }
}