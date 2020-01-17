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
    public class PizzasController : ControllerBase
    {

        private _2019SBDContext _context;

        public PizzasController(_2019SBDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getPizzas()
        {
            return Ok(_context.AchPizza.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult getPizza(int id)
        {
            var pizza = _context.AchPizza.FirstOrDefault(e => e.IdPizza == id);

            if (pizza == null)
            { return NotFound(); }

            return Ok(pizza);

        }



        [HttpPost]
        public IActionResult Create(AchPizza newItem)
        {

            var newId = _context.AchPizza.OrderByDescending(i => i.IdPizza).FirstOrDefault().IdPizza + 1;
            newItem.IdPizza = newId;


            _context.AchPizza.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchPizza updated_item)
        {



            var item = _context.AchPizza.Count(e => e.IdPizza == item_id);

            if (item == 0)
            {
                return NotFound();
            }

            _context.AchPizza.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);

        }

        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchPizza.FirstOrDefault(e => e.IdPizza == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchPizza.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }




    }
}